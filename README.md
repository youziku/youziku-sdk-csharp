# 一、下载
1. <a href="https://github.com/youziku/youziku-sdk-csharp/raw/master/sdk/Youziku.SDK.v45.zip">SDK(支持.NET Framework version为4.5及以上版本调用；支持异步调用) <br />
2. <a href="https://github.com/youziku/youziku-sdk-csharp/raw/master/sdk/Youziku.SDK.v35.zip">SDK(支持.NET Framework version为3.5及以上版本调用；只支持异步用)
<br />

# 二、介绍

SDK适用于在C#语言中调用service.youziku.com中的所有api

# 三、Sample
## 1.初始化YouzikuServiceClient实例,在全局配置一遍即可
```csharp 
public static readonly IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(apiKey: "xxxxxx");
```
## 2.单标签模式
### 2.1 GetFontface()
#### 备注:直接返回所有格式的@fontface
同步调用
``` csharp
var response = youzikuClient.GetFontFace(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "有字库，让中文跃上云端！",
    Tag = "#id1"
});
```
异步调用
``` csharp
var response = await youzikuClient.GetFontFaceAsync(new FontFaceParam
{
      AccessKey = "xxx",
      Content = "有字库，让中文跃上云端！",
      Tag = "#id1"
});
```
### 2.2 GetWoffBase64StringFontFace()
#### 备注：直接返回流（woff流）的@fontface
同步调用
``` csharp
var response = youzikuClient.GetWoffBase64StringFontFace(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "有字库，让中文跃上云端！",
    Tag = "#id1"
});
```
异步调用
``` csharp
var response = await youzikuClient.GetWoffBase64StringFontFaceAsync(new FontFaceParam
{
      AccessKey = "xxx",
      Content = "有字库，让中文跃上云端！",
      Tag = "#id1"
});
```
## 3.多标签生成模式
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
    Content = "有字库，让中文跃上云端！",
    Tag = "#id1"
});

param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "有字库，让中文跃上云端！",
    Tag = ".class1"
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
    Content = "有字库，让中文跃上云端！",
    Tag = "#id1"
});

param.Tags.Add(new FontFaceParam
{
    AccessKey = "xxx",
    Content = "有字库，让中文跃上云端！",
    Tag = ".class1"
});
var response = await youzikuClient.GetBatchFontFaceAsync(param);
```
### 2.GetBatchWoffFontFace ()
#### 备注：直接返回仅woff格式的@fontface
同步调用
``` csharp
//构建一个请求参数
var param2 = new BatchFontFaceParam();
//开始构建生成项
param2.Tags.Add(new FontFaceParam
{
     AccessKey = "xxx",
     Content = "有字库，让中文跃上云端！",
     Tag = "#id1"
});
param2.Tags.Add(new FontFaceParam
{
     AccessKey = "xxx",
     Content = "有字库，让中文跃上云端！",
     Tag = ".class1"
});

var response =  youzikuClient.GetBatchWoffFontFace(param2);
```
异步调用
``` csharp
//构建一个请求参数
var param2 = new BatchFontFaceParam();
//开始构建生成项
param2.Tags.Add(new FontFaceParam
{
     AccessKey = "xxx",
     Content = "有字库，让中文跃上云端！",
     Tag = "#id1"
});
param2.Tags.Add(new FontFaceParam
{
     AccessKey = "xxx",
     Content = "有字库，让中文跃上云端！",
     Tag = ".class1"
});

var response = await youzikuClient.GetBatchWoffFontFaceAsync(param2);
```
## 4.自定义路径生成模式
### 1.CreateBatchWoffWebFontAsync()
#### 备注：自定义路径接口可以被程序异步调用，程序调用后可以直接向下执行，不需要等待返回值
同步调用
``` csharp
//构建一个请求参数
var cusParam = new BatchCustomPathWoffFontFaceParam();
//开始构建生成项
cusParam.Datas.Add(new CustomPathFontFaceParam
{
      AccessKey = "xxx",
      Content = "有字库，让中文跃上云端！",
      Url = "youziku/test-1"
});
cusParam.Datas.Add(new CustomPathFontFaceParam
{
       AccessKey = "xxx",
       Content = "有字库，让中文跃上云端！",
       Url = "youziku/test-2"
});

var response =  youzikuClient.GetCustomPathBatchWoffWebFont(cusParam);
```
异步调用
``` csharp
//构建一个请求参数
var cusParam = new BatchCustomPathWoffFontFaceParam();
//开始构建生成项
cusParam.Datas.Add(new CustomPathFontFaceParam
{
      AccessKey = "xxx",
      Content = "有字库，让中文跃上云端！",
      Url = "youziku/test-1"
});
cusParam.Datas.Add(new CustomPathFontFaceParam
{
       AccessKey = "xxx",
       Content = "有字库，让中文跃上云端！",
       Url = "youziku/test-2"
});

var response = await youzikuClient.GetCustomPathBatchWoffWebFontAsync(cusParam);
```
