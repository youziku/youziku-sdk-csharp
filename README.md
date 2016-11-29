# 一、介绍

## 1．SDK适用语言<br/>
SDK适用于在C#(或其他.NET框架下语言)中调用<a  target="_blank"  href="http://service.youziku.com">service.youziku.com</a>中的所有api<br/>

## 2.工作流程<br/>
　　①用户用后台程序调用SDK，提交动态内容到有字库的子集化(裁切)服务器<br/>
　　②服务器根据内容裁剪出对应的小字体文件，并转换为4种通用字体格式（woff、eot、ttf、svg）<br/>
　　③服务器将所有字体文件上传至阿里云CDN<br/>
　　④服务器用文件的CDN路径拼出@font-face语句<br/>
　　⑤服务器通过SDK将@font-face语句返回给用户的后台程序<br/>

## 3.@font-face语句<br/>
SDK的返回值主要内容是@font-face语句，@font-face语句是CSS3中的一个功能模块，是所有浏览器天然支持的CSS语句。它的作用是将一个远程字体文件加载到当前页面，并且定义成一个字体，前端页面能够像使用本地字体一样使用该字体。@font-face语句是实现在线字体效果的核心代码。<br/>

## 4. 显示字体效果
用户可以将@font-face语句与内容相对应保存至数据库，以便在内容被加载时，该语句能跟随内容一起加载到前端页面，从而使内容显示字体效果；<br/>
用户也可以不保存@font-face语句：有字库允许用户自定义字体存放路径，当需要显示字体效果时，可以根据自己所定义的路径拼出@font-face语句，然后将语句输出到前端页面，即可使内容显示字体效果。

# 二、下载
1. <a href="https://github.com/youziku/youziku-sdk-csharp/raw/master/sdk/Youziku.SDK.v35.zip">SDK</a>(兼容.NET Framework version 3.5及以上所有版本；) <br />
2. <a href="https://github.com/youziku/youziku-sdk-csharp/raw/master/sdk/Youziku.SDK.v45.zip">SDK</a>(兼容.NET Framework version 4.5及以上所有版本；增加对异步调用[使用async和await]的支持)

# 三、引用
## 1.添加引用（Youziku.SDK.dll）
## 2.引用命名空间
``` csharp
using Youziku.Client;
using Youziku.Param.Batch;
using Youziku.Param;
```

# 四、Sample
## 1.初始化YouzikuServiceClient实例,在全局配置一遍即可
```csharp 
public static readonly IYouzikuServiceClient youzikuClient = new YouzikuServiceClient("xxxxxx");//apiKey
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
    Content = "有字库，让前端掌控字体！",
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
    Content = "有字库，让前端掌控字体！",
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
     Content = "有字库，让前端掌控字体！",
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
     Content = "有字库，让前端掌控字体！",
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
       Content = "有字库，让前端掌控字体！",
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
       Content = "有字库，让前端掌控字体！",
       Url = "youziku/test-2"
});

var response = await youzikuClient.GetCustomPathBatchWoffWebFont(cusParam);
```
