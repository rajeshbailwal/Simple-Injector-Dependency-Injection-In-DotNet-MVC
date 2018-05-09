<html>

<head>
<meta http-equiv=Content-Type content="text/html; charset=windows-1252">
<meta name=Generator content="Microsoft Word 15 (filtered)">
<style>
<!--
 /* Font Definitions */
 @font-face
	{font-family:"Cambria Math";
	panose-1:2 4 5 3 5 4 6 3 2 4;}
@font-face
	{font-family:Calibri;
	panose-1:2 15 5 2 2 2 4 3 2 4;}
@font-face
	{font-family:Consolas;
	panose-1:2 11 6 9 2 2 4 3 2 4;}
 /* Style Definitions */
 p.MsoNormal, li.MsoNormal, div.MsoNormal
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:8.0pt;
	margin-left:0in;
	line-height:107%;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;}
p.MsoListParagraph, li.MsoListParagraph, div.MsoListParagraph
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:8.0pt;
	margin-left:.5in;
	line-height:107%;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;}
p.MsoListParagraphCxSpFirst, li.MsoListParagraphCxSpFirst, div.MsoListParagraphCxSpFirst
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:.5in;
	margin-bottom:.0001pt;
	line-height:107%;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;}
p.MsoListParagraphCxSpMiddle, li.MsoListParagraphCxSpMiddle, div.MsoListParagraphCxSpMiddle
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:.5in;
	margin-bottom:.0001pt;
	line-height:107%;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;}
p.MsoListParagraphCxSpLast, li.MsoListParagraphCxSpLast, div.MsoListParagraphCxSpLast
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:8.0pt;
	margin-left:.5in;
	line-height:107%;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;}
.MsoChpDefault
	{font-family:"Calibri",sans-serif;}
.MsoPapDefault
	{margin-bottom:8.0pt;
	line-height:107%;}
@page WordSection1
	{size:8.5in 11.0in;
	margin:1.0in 1.0in 1.0in 1.0in;}
div.WordSection1
	{page:WordSection1;}
 /* List Definitions */
 ol
	{margin-bottom:0in;}
ul
	{margin-bottom:0in;}
-->
</style>

</head>

<body lang=EN-US>
<div id="readme" class="readme blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="text"><h1><a id="user-content-ninject" class="anchor" aria-hidden="true" href="#ninject"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Simple Injector</h1>
<p>Simple Injector is an easy-to-use Dependency Injection (DI) library for .NET 4+ that supports Silverlight, Windows Phone, Windows 8 including Universal apps and Mono. Simple Injector is easily integrated with frameworks such as Web API, MVC, WCF, ASP.NET Core and many others. It’s easy to implement the dependency injection pattern with loosely coupled components using Simple Injector.</p>
<a href="https://simpleinjector.org/index.html">Read use of Simple Injector on offical website  </a>
<br/><br/>
<p><em>Step by step guide to implement sinple injector in MVC. Sample code is created in Visual studio 2017 community edition</em></p>

<div class=WordSection1>

<p class=MsoNormal><span style='font-size:13.0pt;line-height:107%'>Steps:</span></p>

<p class=MsoNormal><span style='font-size:13.0pt;line-height:107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpFirst style='text-indent:-.25in'><span
style='font-size:13.0pt;line-height:107%'>1.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style='font-size:13.0pt;line-height:107%'>Open visual
studio and create web application selecting MVC.</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><img width=283 height=406 id="Picture 1" src="Images_files/image001.png"></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-.25in'><span
style='font-size:13.0pt;line-height:107%'>2.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style='font-size:13.0pt;line-height:107%'>Run the
application. while running application in visual studio 2017 community, you can
see below screen, if not jump to next step.</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><img width=624 height=225 id="Picture 2" src="Images_files/image002.jpg"></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>So wait until the application get loads, it was taking too much time so
you can disable it from tools-&gt;options-&gt;debugging and uncheck the item</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><img width=624 height=348 id="Picture 3" src="Images_files/image003.jpg"></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-.25in'><span
style='font-size:13.0pt;line-height:107%'>3.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style='font-size:13.0pt;line-height:107%'>Once application
loaded you can see</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><img width=624 height=311 id="Picture 4" src="Images_files/image004.jpg"></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-.25in'><span
style='font-size:13.0pt;line-height:107%'>4.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style='font-size:13.0pt;line-height:107%'>Install “</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:blue'>SimpleInjector.Integration.Web.Mvc”</span><span
style='font-size:13.0pt;line-height:107%'>  package from nugget, it will
install all dependencies. Packages.config file will have now entries </span></p>

<p class=MsoListParagraphCxSpLast><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;text-indent:
.5in;line-height:normal;text-autospace:none'><span style='font-size:13.0pt;
font-family:Consolas;color:blue'>&lt;</span><span style='font-size:13.0pt;
font-family:Consolas;color:#A31515'>package</span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'> </span><span style='font-size:13.0pt;
font-family:Consolas;color:red'>id</span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'>=</span><span style='font-size:13.0pt;
font-family:Consolas;color:black'>&quot;</span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'>SimpleInjector</span><span style='font-size:
13.0pt;font-family:Consolas;color:black'>&quot;</span><span style='font-size:
13.0pt;font-family:Consolas;color:blue'> </span><span style='font-size:13.0pt;
font-family:Consolas;color:red'>version</span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'>=</span><span style='font-size:13.0pt;
font-family:Consolas;color:black'>&quot;</span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'>4.2.2</span><span style='font-size:13.0pt;
font-family:Consolas;color:black'>&quot;</span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'> </span><span style='font-size:13.0pt;
font-family:Consolas;color:red'>targetFramework</span><span style='font-size:
13.0pt;font-family:Consolas;color:blue'>=</span><span style='font-size:13.0pt;
font-family:Consolas;color:black'>&quot;</span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'>net461</span><span style='font-size:13.0pt;
font-family:Consolas;color:black'>&quot;</span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'> /&gt;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:46.5pt;margin-bottom:.0001pt;line-height:normal;text-autospace:
none'><span style='font-size:13.0pt;font-family:Consolas;color:blue'>&lt;</span><span
style='font-size:13.0pt;font-family:Consolas;color:#A31515'>package</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:red'>id</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>SimpleInjector.Integration.Web</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:red'>version</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>4.2.2</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:red'>targetFramework</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>net461</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'> /&gt;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:46.5pt;margin-bottom:.0001pt;line-height:normal;text-autospace:
none'><span style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:46.5pt;margin-bottom:.0001pt;line-height:normal;text-autospace:
none'><span style='font-size:13.0pt;font-family:Consolas;color:blue'>&lt;</span><span
style='font-size:13.0pt;font-family:Consolas;color:#A31515'>package</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:red'>id</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>SimpleInjector.Integration.Web.Mvc</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:red'>version</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>4.2.2</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:red'>targetFramework</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>net461</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'> /&gt;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:46.5pt;margin-bottom:.0001pt;line-height:normal;text-autospace:
none'><span style='font-size:13.0pt'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpFirst style='text-indent:-.25in'><span
style='font-size:13.0pt;line-height:107%'>5.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style='font-size:13.0pt;line-height:107%'>Add two projects
“DataAccess” and “EntityModel”. Dataaccess is for interacting with database and
entity model will contains entities. Add references of these projects in “App”
project</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><img width=338 height=85 id="Picture 5" src="Images_files/image005.png"></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-.25in'><span
style='font-size:13.0pt;line-height:107%'>6.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style='font-size:13.0pt;line-height:107%'>In DataAccess
layer, create one folder “Interface” and interface file “</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:#2B91AF'>ICompanyRepository.cs</span><span
style='font-size:13.0pt;line-height:107%'>”</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpLast><span style='font-size:13.0pt;line-height:
107%'>File contents:</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>namespace</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> DataAccess.Interface</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>{</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>interface</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:#2B91AF'>ICompanyRepository</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        List&lt;Company&gt;
GetCompanies();</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    }</span></p>

<p class=MsoNormal style='text-indent:.5in'><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;color:black'>}</span></p>

<p class=MsoNormal style='text-indent:.5in'><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpFirst><span style='font-size:13.0pt;line-height:
107%'>Now, create “Repository” folder and add class file
“CompanySqlRepository.cs”. Implement interface and created the constructor to
inject IDbConnection which will return sqlconnection. </span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>To check IDbConnection, I am just going to open sql connection and
getting it close.</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>Add your sql connection string in web.config file</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%;font-family:Consolas;color:blue'>&lt;</span><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;color:#A31515'>add</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:blue'> </span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:red'>name</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:blue'>mssql</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:blue'> </span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:red'>connectionString</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:blue'>Data
Source=#DataSourceName#; Integrated Security=True;User ID=sa;
Password=#password#; Initial Catalog=#DatabaseName#;</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:blue'>
/&gt;</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpLast><span style='font-size:13.0pt;line-height:
107%'>File contents:</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
System.Collections.Generic;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> System.Data;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
DataAccess.Interface;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
EntityModel.DomainModel;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
System.Configuration;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>namespace</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
DataAccess.Repository.Dapper.MSSQL</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>{</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>class</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:#2B91AF'>CompanySqlRepository</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> : ICompanyRepository</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>private</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> IDbConnection
_connection;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
CompanySqlRepository(IDbConnection conn)</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>           
_connection = conn;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>           
_connection.ConnectionString = ConfigurationManager.ConnectionStrings[</span><span
style='font-size:13.0pt;font-family:Consolas;color:#A31515'>&quot;mssql&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>].ConnectionString;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        }</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> List&lt;Company&gt;
GetCompanies()</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>            <span
style='background:yellow'>_connection.Open();</span></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>            <span
style='background:yellow'>_connection.Close();</span></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>            </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>var</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> lstCompany = </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
List&lt;Company&gt;()</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>            {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>                </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> Company{Id=1, Name=</span><span
style='font-size:13.0pt;font-family:Consolas;color:#A31515'>&quot;Microsoft&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> },</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>                </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> Company{Id=2, Name=</span><span
style='font-size:13.0pt;font-family:Consolas;color:#A31515'>&quot;Google&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> },</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>                </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> Company{Id=3, Name=</span><span
style='font-size:13.0pt;font-family:Consolas;color:#A31515'>&quot;Facebook&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> },</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>                </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> Company{Id=4, Name=</span><span
style='font-size:13.0pt;font-family:Consolas;color:#A31515'>&quot;Tesla&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> },</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>                </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> Company{Id=5, Name=</span><span
style='font-size:13.0pt;font-family:Consolas;color:#A31515'>&quot;HP&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> }</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>            };</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>            </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>return</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> lstCompany;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        }</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    }</span></p>

<p class=MsoNormal style='text-indent:.5in'><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;color:black'>}</span></p>

<p class=MsoListParagraphCxSpFirst style='text-indent:-.25in'><span
style='font-size:13.0pt;line-height:107%'>7.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style='font-size:13.0pt;line-height:107%'>Create “</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;color:#2B91AF'>ApplicationDependencyResolver.cs</span><span
style='font-size:13.0pt;line-height:107%'>” file under App_start folder and add
namespace “</span><span style='font-size:13.0pt;line-height:107%;font-family:
Consolas;color:blue'>using</span><span style='font-size:13.0pt;line-height:
107%;font-family:Consolas;color:black'> SimpleInjector;”</span><span
style='font-size:13.0pt;line-height:107%'>. Mark class as static and will start
creating method which contains all dependencies related to project.</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>Here we are going to add dependencies for IDbConnection and
ICompanyRepository, before this it’s important to Register MVC Controllers and
Filter Providers.</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpLast><span style='font-size:13.0pt;line-height:
107%'>Code:</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
DataAccess.Interface;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
DataAccess.Repository.Dapper.MSSQL;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> SimpleInjector;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
System.Configuration;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> System.Data;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
System.Data.SqlClient;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>namespace</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> App.App_Start</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>{</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>Public static</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>class</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:#2B91AF'>ApplicationDependencyResolver</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>static</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>void</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
RegisterApplicationDependencies(Container container)</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>           
container.RegisterMvcControllers();</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>           
container.RegisterMvcIntegratedFilterProvider();</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:99.0pt;margin-bottom:.0001pt;text-indent:-63.0pt;line-height:normal;
text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>            container.Register&lt;ICompanyRepository,
CompanySqlRepository&gt;(Lifestyle.Scoped);</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:99.0pt;margin-bottom:.0001pt;text-indent:-63.0pt;line-height:normal;
text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:99.0pt;margin-bottom:.0001pt;text-indent:-63.0pt;line-height:normal;
text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>            container.Register&lt;IDbConnection&gt;(() =&gt; </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
SqlConnection(ConfigurationManager.ConnectionStrings[</span><span
style='font-size:13.0pt;font-family:Consolas;color:#A31515'>&quot;mssql&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>].ConnectionString),
Lifestyle.Scoped);</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        }</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    }</span></p>

<p class=MsoNormal style='margin-left:.5in'><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;color:black'>}</span></p>

<p class=MsoNormal><span style='font-size:13.0pt;line-height:107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpFirst><span style='font-size:13.0pt;line-height:
107%;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-.25in'><span
style='font-size:13.0pt;line-height:107%'>8.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style='font-size:13.0pt;line-height:107%'>Next step to
initialize injector, create new file  “</span><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;color:#2B91AF'>SimpleInjectorWebInitializer.cs</span><span
style='font-size:13.0pt;line-height:107%'>” and mark class as static.  It is
must to define “DefaultScopedLifeStyle” else it will throw error.  If you want
to add comman dependencies throughout the application like logger or cache,
then register as singleton. I have created method for it. As of now it is
commented. Let’s focus on interface ICompanyRepository injection.</span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpLast><span style='font-size:13.0pt;line-height:
107%'>File contents:</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> SimpleInjector;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
SimpleInjector.Integration.Web;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> System;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> System.Web.Mvc;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
SimpleInjector.Integration.Web.Mvc;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:green'>//add assembly
System.Runtime.Caching for it</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
System.Runtime.Caching;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> log4net;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>namespace</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> App.App_Start</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>{</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>static</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>class</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:#2B91AF'>SimpleInjectorWebInitializer</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>static</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>void</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
InitilizeContainer(Action&lt;Container&gt; registerApplicationDependencies)</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>            GetInitializeContainer(registerApplicationDependencies);</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        }</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>static</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> Container
GetInitializeContainer(Action&lt;Container&gt; registerApplicationDependencies)</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>            </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>var</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> container = </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> Container();</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>           
Initialize(container, registerApplicationDependencies);</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>            </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>return</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> container;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        }</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>private</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>static</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>void</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> Initialize(Container
container, Action&lt;Container&gt; registerApplicationDependencies)</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>           
container.Options.DefaultScopedLifestyle = </span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'>new</span><span style='font-size:13.0pt;
font-family:Consolas;color:black'> WebRequestLifestyle();</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>           
RegisterCommandDependencies(container);</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>           
registerApplicationDependencies.Invoke(container);</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>           
DependencyResolver.SetResolver(</span><span style='font-size:13.0pt;font-family:
Consolas;color:blue'>new</span><span style='font-size:13.0pt;font-family:Consolas;
color:black'> SimpleInjectorDependencyResolver(container));</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        }</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:gray'>///</span><span
style='font-size:13.0pt;font-family:Consolas;color:green'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:gray'>&lt;summary&gt;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:gray'>///</span><span
style='font-size:13.0pt;font-family:Consolas;color:green'> This class is to
register commandepencies through out the application, like logger, cache</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:gray'>///</span><span
style='font-size:13.0pt;font-family:Consolas;color:green'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:gray'>&lt;/summary&gt;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>private</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>static</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>void</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>
RegisterCommandDependencies(Container container)</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>            </span><span
style='font-size:13.0pt;font-family:Consolas;color:green'>//container.RegisterSingleton&lt;ObjectCache&gt;(MemoryCache.Default);</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>            </span><span
style='font-size:13.0pt;font-family:Consolas;color:green'>//container.RegisterSingleton&lt;ILog&gt;(LogManager.GetLogger(&quot;&quot;));</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        }</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    }</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>}</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpFirst style='text-indent:-.25in'><span
style='font-size:13.0pt;line-height:107%'>9.<span style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style='font-size:13.0pt;line-height:107%'>Final step to
call Initialize from Global.asax file</span></p>

<p class=MsoListParagraphCxSpLast style='margin-bottom:0in;margin-bottom:.0001pt;
line-height:normal;text-autospace:none'><span style='font-size:13.0pt;
font-family:Consolas;color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>protected</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>void</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'> Application_Start()</span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>        {</span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>            AreaRegistration.RegisterAllAreas();</span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:63.0pt;margin-bottom:.0001pt;text-indent:-63.0pt;line-height:normal;
text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>            Action&lt;Container&gt; registerApplictionDependencies
= ApplicationDependencyResolver.RegisterApplicationDependencies;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:63.0pt;margin-bottom:.0001pt;line-height:normal;text-autospace:
none'><span style='font-size:13.0pt;font-family:Consolas;color:black'>           
SimpleInjectorWebInitializer.InitilizeContainer(registerApplictionDependencies);</span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>&nbsp;</span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>           
FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);</span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>            RouteConfig.RegisterRoutes(RouteTable.Routes);</span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>            BundleConfig.RegisterBundles(BundleTable.Bundles);</span></p>

<p class=MsoListParagraphCxSpFirst style='margin-top:0in;margin-right:0in;
margin-bottom:0in;margin-left:.25in;margin-bottom:.0001pt;line-height:normal;
text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>     }</span></p>

<p class=MsoListParagraphCxSpMiddle style='margin-top:0in;margin-right:0in;
margin-bottom:0in;margin-left:.25in;margin-bottom:.0001pt;line-height:normal;
text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
color:black'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpLast style='margin-bottom:0in;margin-bottom:.0001pt;
text-indent:-.25in;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>10.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style='font-size:13.0pt;font-family:Consolas;color:black'>Open
Index.cshtml in views folder and add following code to list companies name</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>&lt;</span><span
style='font-size:13.0pt;font-family:Consolas;color:maroon'>div</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>&gt;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    <span
style='background:yellow'>@</span></span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'>foreach</span><span style='font-size:13.0pt;
font-family:Consolas;color:black'> (var item </span><span style='font-size:
13.0pt;font-family:Consolas;color:blue'>in</span><span style='font-size:13.0pt;
font-family:Consolas;color:black'> ViewBag.Companies)</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    {</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>        </span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>&lt;</span><span
style='font-size:13.0pt;font-family:Consolas;color:maroon'>li</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>&gt;</span><span
style='font-size:13.0pt;font-family:Consolas;color:black;background:yellow'>@</span><span
style='font-size:13.0pt;font-family:Consolas;color:black'>item.Id: <span
style='background:yellow'>@</span>item.Name</span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'>&lt;/</span><span style='font-size:13.0pt;
font-family:Consolas;color:maroon'>li</span><span style='font-size:13.0pt;
font-family:Consolas;color:blue'>&gt;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>    }</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>&lt;/</span><span
style='font-size:13.0pt;font-family:Consolas;color:maroon'>div</span><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>&gt;</span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:blue'>&nbsp;</span></p>

<p class=MsoListParagraphCxSpFirst style='margin-bottom:0in;margin-bottom:.0001pt;
text-indent:-.25in;line-height:normal;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;color:black'>11.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span><span style='font-size:13.0pt'>Run application and it will show
list of companies</span></p>

<p class=MsoListParagraphCxSpLast style='margin-bottom:0in;margin-bottom:.0001pt;
line-height:normal;text-autospace:none'><span style='font-size:13.0pt'><img
width=623 height=286 id="Picture 6" src="Images_files/image006.jpg"></span></p>

</div>

</body>

</html>
