//(CWE-501)

usrname = request.Item("usrname"); 
if (session.Item(ATTR_USR) == null) { 
session.Add(ATTR_USR, usrname); 
} 


