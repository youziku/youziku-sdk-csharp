# 一、环境
.NET Framework版本：4.5

# 二、介绍

适用于在C#中调用service.youziku.com中的所有接口

# 三、Sample
## 1.初始化客户端实例
### 初始化方式1
```csharp
public static IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(new YouzikuConfig()
{
   Host = "http://service.youziku.com",
   ApiKey = "xxxxxx"
});

```
### 初始化方式2
```csharp 
publci static IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(host: "http://service.youziku.com", apiKey: "xxxxxx");
```
## 2.单标签模式
### 2.1 GetFontface()接口
同步调用
``` csharp
var response = youzikuClient.GetFontFace(new FontFaceParam
     {
           AccessKey = "xxx",
           Content = "jamesbing Inc.",
           Tag = "#gg"
      });
```
异步调用
``` csharp
 var response = await youzikuClient.GetFontFaceAsync(new FontFaceParam
     {
           AccessKey = "xxx",
           Content = "jamesbing Inc.",
           Tag = "#gg"
      });
```
