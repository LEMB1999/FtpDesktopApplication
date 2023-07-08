# FtpDesktopApplication
this application connects with FTP server to upload files

# Setup
its necessary configure , to , from and credentials in the button click function

# Docker Compose 
We use fauria/vsftpd  image to setup FTP server, this command start the service.
```
docker run -d  -p 20:20 -p 21:21 -p 21100-21110:21100-21110 -e FTP_USER=user -e FTP_PASS=mypass -e PASV_ADDRESS=127.0.0.1 -e PASV_MIN_PORT=21100 -e PASV_MAX_PORT=21110 --name vsftpd --restart=always fauria/vsftpd
```
