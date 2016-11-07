#一、环境
.NET Framework版本：4.5

#二、介绍
适用于在C#中调用service.youziku.com中的所有接口

#三、初始化客户端实例
static IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(host: "http://service.youziku.com", apiKey: "xxxxxx");

