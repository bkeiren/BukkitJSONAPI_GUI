using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CommonData;
using System.Net;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Core;

namespace BukkitJSONAPI_Updater
{
    public partial class Form1 : Form
    {
        UpdatesObject updates = null;
        UpdatesObject updatesFromWeb = null;
        WebClient wc = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForUpdates();
        }

        private void Done()
        {
            StatusLabel.Text = "Done.";

            // Start GUI process with noupdate flag, terminate this form.
            System.Diagnostics.Process guiProcess = System.Diagnostics.Process.Start("BukkitJSONAPI_GUI.exe", "noupdate");
            this.Close();
        }

        private void DownloadFileAsynCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Done();
            }
            else if (e.Error != null)
            {
                Done();
            }
            else
            {
                StatusLabel.Text = "Applying update...";

                ExtractZipFile("..\\update.zip", "", "..\\");
                // TODO: Copy content from update.zip to program folder, overwriting
                // existing files.
                // Overwrite ..\\updates.json with updatesFromWeb object.
                string serializedUpdatesFromWeb = Newtonsoft.Json.JsonConvert.SerializeObject(updatesFromWeb, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("..\\updates.json", serializedUpdatesFromWeb);
                File.Delete(@"..\\update.zip");
                Done();
            }
        }

        private void DownloadStringAsynCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Done();
            }
            else if (e.Error != null)
            {
                Done();
            }
            else
            {
                string UpdatesFileFromWeb = e.Result;
                if (UpdatesFileFromWeb != null && UpdatesFileFromWeb != string.Empty)
                {
                    updatesFromWeb = Newtonsoft.Json.JsonConvert.DeserializeObject<UpdatesObject>(UpdatesFileFromWeb);
                    if (updatesFromWeb == null)
                    {
                        Done();
                        return;
                    }

                    // If a newer version is on the server.
                    if (updatesFromWeb.version != null &&
                        updates.version != null &&
                        updatesFromWeb.version > updates.version)
                    {
                        StatusLabel.Text = "Downloading update...";
                        try
                        {
                            wc.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.DownloadFileAsynCompleted);
                            System.Uri uri = new System.Uri(updates.location + updates.file);
                            wc.DownloadFileAsync(uri, "..\\update.zip");
                        }
                        catch (System.Net.WebException ex)
                        {
                            Console.WriteLine("Something went wrong while trying to download an update!");
                            Done();
                        }
                    }
                    else
                    {
                        Done();
                    }
                }
                else
                {
                    Done();
                }
            }
        }

        private void CheckForUpdates()
        {
            StatusLabel.Text = "Checking for updates...";
            string UpdatesFile = File.ReadAllText("..\\updates.json");
            if (UpdatesFile != null && UpdatesFile != string.Empty)
            {
                updates = Newtonsoft.Json.JsonConvert.DeserializeObject<UpdatesObject>(UpdatesFile);
                if (updates == null)
                {
                    Done();
                    return;
                }

                using (wc = new WebClient())
                {
                    wc.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(this.DownloadProgressChanged);
                    wc.DownloadStringCompleted += new System.Net.DownloadStringCompletedEventHandler(this.DownloadStringAsynCompleted);

                    System.Uri uri = new System.Uri(updates.location + "updates.json");
                    wc.DownloadStringAsync(uri);
                }
            }
            else
            {
                Done();
            }
        }

        public void ExtractZipFile(string archiveFilenameIn, string password, string outFolder)
        {
            ZipFile zf = null;
            try
            {
                FileStream fs = File.OpenRead(archiveFilenameIn);
                zf = new ZipFile(fs);
                if (!String.IsNullOrEmpty(password))
                {
                    zf.Password = password;     // AES encrypted entries are handled automatically
                }
                foreach (ZipEntry zipEntry in zf)
                {
                    if (!zipEntry.IsFile)
                    {
                        continue;           // Ignore directories
                    }
                    String entryFileName = zipEntry.Name;
                    // to remove the folder from the entry:- entryFileName = Path.GetFileName(entryFileName);
                    // Optionally match entrynames against a selection list here to skip as desired.
                    // The unpacked length is available in the zipEntry.Size property.

                    byte[] buffer = new byte[4096];     // 4K is optimum
                    Stream zipStream = zf.GetInputStream(zipEntry);

                    // Manipulate the output filename here as desired.
                    String fullZipToPath = Path.Combine(outFolder, entryFileName);
                    string directoryName = Path.GetDirectoryName(fullZipToPath);
                    if (directoryName.Length > 0)
                        Directory.CreateDirectory(directoryName);

                    // Unzip file in buffered chunks. This is just as fast as unpacking to a buffer the full size
                    // of the file, but does not waste memory.
                    // The "using" will close the stream even if an exception occurs.
                    using (FileStream streamWriter = File.Create(fullZipToPath))
                    {
                        StreamUtils.Copy(zipStream, streamWriter, buffer);
                    }
                }
            }
            finally
            {
                if (zf != null)
                {
                    zf.IsStreamOwner = true; // Makes close also shut the underlying stream
                    zf.Close(); // Ensure we release resources
                }
            }
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }
    }
}
