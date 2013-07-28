import sys
import argparse

try:
	from MinecraftJsonAPI import MinecraftJsonApi
except ImportError:
	print("Failed to import MinecraftJSONAPI")
	sys.exit(0)

if __name__ == '__main__':
	ArgParser = argparse.ArgumentParser()
	ArgParser.add_argument("host", metavar="HOST", help="address of the server host.", default="localhost")
	ArgParser.add_argument("port", metavar="PORT", help="port number used by JSONAPI on the server.", default=20059)
	ArgParser.add_argument("username", metavar="USERNAME", help="JSONAPI username.", default='admin')
	ArgParser.add_argument("password", metavar="PASSWORD", help="JSONAPI password.", default='cowbell')
	ArgParser.add_argument("salt", metavar="SALT", help="JSONAPI salt.", default='')
	ArgParser.add_argument("method", nargs="?", metavar="METHOD", help="JSONAPI method to call. If absent, program will enter loop mode which allows for you to enter any number of commands", default=None)
	ArgParser.add_argument("args", nargs="*", metavar="ARGS", help="Arguments for the method call", default=None)
	Args = ArgParser.parse_args()
		
	paramDefaults = {'host': Args.host, 'port':Args.port, 'username':Args.username, 'password':Args.password, 'salt':Args.salt}
	filterFuncs = {'host': str, 'port': int, 'username': str, 'password': str, 'salt': str}
	params = paramDefaults
	
	#params = {}	
	#for k in list(paramDefaults.keys()):
	#	value = input("%s (%s): " % (k.capitalize(), str(paramDefaults[k])))
	#	if len(value):
	#		params[k] = filterFuncs[k](value)
	#	else:
	#		params[k] = paramDefaults[k]

	api = MinecraftJsonApi(
		host = params['host'], 
		port = params['port'], 
		username = params['username'], 
		password = params['password'], 
		salt = params['salt']
	)
	
	if (Args.method != None):
		#print(Args.method)
		#if (Args.args != None):
		#	print(Args.args)
		print(api.call(Args.method, *Args.args))
	else:
		#print([m['method_name'] for m in api.getLoadedMethods()])
		#print((api.getMethod('kickPlayer')))	
		x = True
		while x:
			#method = input('>')
			#print((api.getMethod(method)))
			method = input('->')
			if method == "exit":
				x = False
				continue
			splitList = method.split(' ')
			arguments = splitList[1:len(splitList)]
			#print("Calling: " + splitList[0])
			#print("Args: " + str(arguments))
			print(api.call(splitList[0], *arguments))