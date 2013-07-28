BukkitJSONAPI GUI
================================

BukkitJSONAPI GUI is s simple software application written in C# and utilizing some Python scripts to communicate with (Craft)Bukkit servers for Minecraft which have the BukkitJSONAPI plugin installed (see *external links* section).

The application allows non-technical users to execute commands on the server by providing an interface which is simpler to understand than just a CLI (command line interface). Using the interface consist of selecting which command to execute (commands have descriptions which explain their purpose), then providing whatever parameters the command requires. The interface clearly indicates the type of the arguments and the number of arguments to be passed.

If the server sends back a reply (i.e.: the executed command has a return value), the user can view this response as either raw text or as a data tree (if the reply is in JSON format).

Additionally, the interface also supports an 'advanced' mode in which the user is allowed to simply enter command parameters similar to a CLI.

Screenshots
--------------------------------

![alt text][screenshot0]

Notes
--------------------------------

Using this software requires the user to have the Python SDK installed (version 3.x and up. developed with Python 3.3).

External Links
--------------------------------

* BukkitJSONAPI plugin: http://dev.bukkit.org/bukkit-plugins/jsonapi/
* Python: http://www.python.org/

[screenshot0]: http://i.imgur.com/imSFnur.png "Screenshot 0"