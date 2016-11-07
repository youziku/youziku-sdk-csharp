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
### 2.1 GetFontface()
#### 备注:直接返回所有格式的@fontface
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
### 2.2 GetWoffBase64StringFontFace()
#### 备注：直接返回流（woff流）的@fontface
``` csharp
var response = youzikuClient.GetWoffBase64StringFontFace(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "jamesbing Inc.",
    Tag = "#gg"
});
```
异步调用
``` csharp
var response = await youzikuClient.GetWoffBase64StringFontFaceAsync(new FontFaceParam
{
      AccessKey = "xxx",
      Content = "jamesbing Inc.",
      Tag = "#gg"
});
```
## 3.多标签生成式
### 1.GetBatchFontFace()
#### 备注：直接返回所有格式的@fontface;可传递多个标签和内容一次生成多个@fontface
同步调用
``` csharp
//构建一个请求参数
var param = new BatchFontFaceParam();
//开始构建生成项
param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "jamesbing1 Inc.",
    Tag = "#gg1"
});

param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "jamesbing2 Inc.",
    Tag = "#gg2"
});
var response =  youzikuClient.GetBatchFontFace(param);
```
异步调用
``` csharp
//构建一个请求参数
var param = new BatchFontFaceParam();
//开始构建生成项
param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "jamesbing1 Inc.",
    Tag = "#gg1"
});

param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "jamesbing2 Inc.",
    Tag = "#gg2"
});
var response = await youzikuClient.GetBatchFontFaceAsync(param);
```
### 2.GetBatchWoffFontFace ()
#### 备注：直接返回仅woff格式的@fontface

