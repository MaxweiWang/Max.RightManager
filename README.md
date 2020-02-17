# Max.CommonManagerSystem
通用后台管理系统

前端：BootStrap 4、Layer、Jquery、Vue

后端：NetCore 3.1.100 一定要安装等于或者大于该版本的SDK


如果部署iis访问不了的情况可以用两种办法：

1、直接打开exe然后控制台看错误

2、web.config里面有个false 改为 true，iis重启项目后运行网站后，跟目录下面 有个文件夹 log 里面有错误日志文件

3、一定注意 项目 bin/netcoreapp2.2/debug/app.xml 放入部署项目的跟目录中 
