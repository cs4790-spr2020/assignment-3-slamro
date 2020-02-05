# BlabberApp

BlabberApp a Twitter-like .NETcore class project

## Assignment 03 (90 points)

- Create an initial business domain classes.  Such as *IDatum*, *Notification*, *Blab*. (30 points)
- Create an in-memory DataStore concrete class. (30 points)
- Write unit-tests for the concrete classes. (30 points)

## SSH Tunneling

SSH tunneling or port forwarding is a technique for viewing a remote web server on your local machine.  It makes it look like the web server is running locally when actually it is running in your account on the class server.  Here is detailed information: [SSH Port Forwarding](https://www.ssh.com/ssh/tunneling/example).  Here is an example of my personal port forwarding command:

`ssh 64.225.37.60 -L 5041:localhost:5041 -N`
