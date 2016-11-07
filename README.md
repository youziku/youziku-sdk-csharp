#一、环境
.NET Framework版本：4.5

#二、介绍

适用于在C#中调用service.youziku.com中的所有接口

#三、Sample
   初始化客户端实例
   //初始化方式1
    static IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(new YouzikuConfig()
    {
         Host = "http://service.youziku.com",
         ApiKey = "xxxxxx"
     });


    //初始化方式2
    static IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(host: "http://service.youziku.com", apiKey: "xxxxxx");

1.单标签模式
  1.1 同步调用
    //GetFontface()接口
     var response = youzikuClient.GetFontFace(new FontFaceParam
     {
           AccessKey = "xxx",
           Content = "jamesbing Inc.",
           Tag = "#gg"
      });
  1.2 异步调用
     //GetFontface()接口
      var response = await youzikuClient.GetFontFaceAsync(new FontFaceParam
     {
           AccessKey = "xxx",
           Content = "jamesbing Inc.",
           Tag = "#gg"
      });
