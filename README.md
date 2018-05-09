
# Simple-Injector-Dependency-Injection-In-DotNet-MVC

<html lang="en">
  <head>
    <meta charset="utf-8">
 


  <link crossorigin="anonymous" media="all" integrity="sha512-AE1SjlpGWrlEnSwNeIPt4xzHKf9cqRgDSKEZilZfa2Eo6yF0O/JHA+sn7rwD8Q0SQZ7mxR6UthJmqpjc7eRufQ==" rel="stylesheet" href="https://assets-cdn.github.com/assets/frameworks-35bdc21c9cfe5499e25ab7ce9d31a2cc.css" />
  <link crossorigin="anonymous" media="all" integrity="sha512-+6WxXk1N5Ci+lJXPAp+eUTjPonxfURryK6uBvTrDuywJoqooHuMH+CZ+gSJ+5P8EBM3Dja0/tcHFoaFd3tzHSg==" rel="stylesheet" href="https://assets-cdn.github.com/assets/github-2287906818783698b1f468d73598604c.css" />
   
  

  <meta name="viewport" content="width=device-width">
  
 </head>

<body>    
  <div id="readme" class="readme blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="text"><h1><a id="user-content-ninject" class="anchor" aria-hidden="true" href="#ninject"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Simple Injector</h1>
<p>Simple Injector is an easy-to-use Dependency Injection (DI) library for .NET 4+ that supports Silverlight, Windows Phone, Windows 8 including Universal apps and Mono. Simple Injector is easily integrated with frameworks such as Web API, MVC, WCF, ASP.NET Core and many others. It’s easy to implement the dependency injection pattern with loosely coupled components using Simple Injector.</p>
<a href="https://simpleinjector.org/index.html">Read use of Simple Injector on offical website  </a>
<br/><br/>
<p><em>Step by step guide to implement sinple injector in MVC. Sample code is created in Visual studio 2017 community edition</em></p>
</body>
</html>
<html >

<head>
<meta http-equiv=Content-Type content="text/html; charset=windows-1252">
<meta name=ProgId content=Word.Document>
<meta name=Generator content="Microsoft Word 15">
<meta name=Originator content="Microsoft Word 15">
<link rel=File-List
href="Images/filelist.xml">
<link rel=Edit-Time-Data
href="Images/editdata.mso">
<!--[if !mso]>
<style>
v\:* {behavior:url(#default#VML);}
o\:* {behavior:url(#default#VML);}
w\:* {behavior:url(#default#VML);}
.shape {behavior:url(#default#VML);}
</style>
<![endif]--><!--[if gte mso 9]><xml>
 <o:DocumentProperties>
  <o:Author>Rajesh</o:Author>
  <o:Template>Normal</o:Template>
  <o:LastAuthor>Rajesh</o:LastAuthor>
  <o:Revision>2</o:Revision>
  <o:TotalTime>563</o:TotalTime>
  <o:Created>2018-05-09T19:34:00Z</o:Created>
  <o:LastSaved>2018-05-09T19:34:00Z</o:LastSaved>
  <o:Pages>1</o:Pages>
  <o:Words>997</o:Words>
  <o:Characters>5685</o:Characters>
  <o:Lines>47</o:Lines>
  <o:Paragraphs>13</o:Paragraphs>
  <o:CharactersWithSpaces>6669</o:CharactersWithSpaces>
  <o:Version>16.00</o:Version>
 </o:DocumentProperties>
 <o:OfficeDocumentSettings>
  <o:AllowPNG/>
 </o:OfficeDocumentSettings>
</xml><![endif]-->
<link rel=dataStoreItem
href="Images/item0001.xml"
target="Images/props002.xml">
<link rel=themeData
href="Images/themedata.thmx">
<link rel=colorSchemeMapping
href="Images/colorschememapping.xml">
<!--[if gte mso 9]><xml>
 <w:WordDocument>
  <w:SpellingState>Clean</w:SpellingState>
  <w:GrammarState>Clean</w:GrammarState>
  <w:TrackMoves>false</w:TrackMoves>
  <w:TrackFormatting/>
  <w:PunctuationKerning/>
  <w:ValidateAgainstSchemas/>
  <w:SaveIfXMLInvalid>false</w:SaveIfXMLInvalid>
  <w:IgnoreMixedContent>false</w:IgnoreMixedContent>
  <w:AlwaysShowPlaceholderText>false</w:AlwaysShowPlaceholderText>
  <w:DoNotPromoteQF/>
  <w:LidThemeOther>EN-US</w:LidThemeOther>
  <w:LidThemeAsian>X-NONE</w:LidThemeAsian>
  <w:LidThemeComplexScript>X-NONE</w:LidThemeComplexScript>
  <w:Compatibility>
   <w:BreakWrappedTables/>
   <w:SnapToGridInCell/>
   <w:WrapTextWithPunct/>
   <w:UseAsianBreakRules/>
   <w:DontGrowAutofit/>
   <w:SplitPgBreakAndParaMark/>
   <w:EnableOpenTypeKerning/>
   <w:DontFlipMirrorIndents/>
   <w:OverrideTableStyleHps/>
  </w:Compatibility>
  <m:mathPr>
   <m:mathFont m:val="Cambria Math"/>
   <m:brkBin m:val="before"/>
   <m:brkBinSub m:val="&#45;-"/>
   <m:smallFrac m:val="off"/>
   <m:dispDef/>
   <m:lMargin m:val="0"/>
   <m:rMargin m:val="0"/>
   <m:defJc m:val="centerGroup"/>
   <m:wrapIndent m:val="1440"/>
   <m:intLim m:val="subSup"/>
   <m:naryLim m:val="undOvr"/>
  </m:mathPr></w:WordDocument>
</xml><![endif]--><!--[if gte mso 9]><xml>
 <w:LatentStyles DefLockedState="false" DefUnhideWhenUsed="false"
  DefSemiHidden="false" DefQFormat="false" DefPriority="99"
  LatentStyleCount="371">
  <w:LsdException Locked="false" Priority="0" QFormat="true" Name="Normal"/>
  <w:LsdException Locked="false" Priority="9" QFormat="true" Name="heading 1"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 2"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 3"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 4"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 5"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 6"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 7"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 8"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 9"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 6"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 7"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 8"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 9"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 1"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 2"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 3"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 4"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 5"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 6"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 7"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 8"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 9"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Normal Indent"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="footnote text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="annotation text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="header"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="footer"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index heading"/>
  <w:LsdException Locked="false" Priority="35" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="caption"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="table of figures"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="envelope address"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="envelope return"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="footnote reference"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="annotation reference"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="line number"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="page number"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="endnote reference"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="endnote text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="table of authorities"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="macro"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="toa heading"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Bullet"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Number"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Bullet 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Bullet 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Bullet 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Bullet 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Number 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Number 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Number 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Number 5"/>
  <w:LsdException Locked="false" Priority="10" QFormat="true" Name="Title"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Closing"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Signature"/>
  <w:LsdException Locked="false" Priority="1" SemiHidden="true"
   UnhideWhenUsed="true" Name="Default Paragraph Font"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text Indent"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Continue"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Continue 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Continue 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Continue 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Continue 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Message Header"/>
  <w:LsdException Locked="false" Priority="11" QFormat="true" Name="Subtitle"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Salutation"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Date"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text First Indent"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text First Indent 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Note Heading"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text Indent 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text Indent 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Block Text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Hyperlink"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="FollowedHyperlink"/>
  <w:LsdException Locked="false" Priority="22" QFormat="true" Name="Strong"/>
  <w:LsdException Locked="false" Priority="20" QFormat="true" Name="Emphasis"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Document Map"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Plain Text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="E-mail Signature"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Top of Form"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Bottom of Form"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Normal (Web)"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Acronym"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Address"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Cite"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Code"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Definition"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Keyboard"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Preformatted"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Sample"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Typewriter"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Variable"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Normal Table"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="annotation subject"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="No List"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Outline List 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Outline List 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Outline List 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Simple 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Simple 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Simple 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Classic 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Classic 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Classic 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Classic 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Colorful 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Colorful 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Colorful 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Columns 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Columns 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Columns 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Columns 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Columns 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 6"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 7"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 8"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 6"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 7"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 8"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table 3D effects 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table 3D effects 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table 3D effects 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Contemporary"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Elegant"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Professional"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Subtle 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Subtle 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Web 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Web 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Web 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Balloon Text"/>
  <w:LsdException Locked="false" Priority="39" Name="Table Grid"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Theme"/>
  <w:LsdException Locked="false" SemiHidden="true" Name="Placeholder Text"/>
  <w:LsdException Locked="false" Priority="1" QFormat="true" Name="No Spacing"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 1"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 1"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 1"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 1"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 1"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 1"/>
  <w:LsdException Locked="false" SemiHidden="true" Name="Revision"/>
  <w:LsdException Locked="false" Priority="34" QFormat="true"
   Name="List Paragraph"/>
  <w:LsdException Locked="false" Priority="29" QFormat="true" Name="Quote"/>
  <w:LsdException Locked="false" Priority="30" QFormat="true"
   Name="Intense Quote"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 1"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 1"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 1"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 1"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 1"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 1"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 1"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 1"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 2"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 2"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 2"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 2"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 2"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 2"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 2"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 2"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 2"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 2"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 2"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 2"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 2"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 2"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 3"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 3"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 3"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 3"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 3"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 3"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 3"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 3"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 3"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 3"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 3"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 3"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 3"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 3"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 4"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 4"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 4"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 4"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 4"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 4"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 4"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 4"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 4"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 4"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 4"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 4"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 4"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 4"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 5"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 5"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 5"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 5"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 5"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 5"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 5"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 5"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 5"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 5"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 5"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 5"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 5"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 5"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 6"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 6"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 6"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 6"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 6"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 6"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 6"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 6"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 6"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 6"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 6"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 6"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 6"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 6"/>
  <w:LsdException Locked="false" Priority="19" QFormat="true"
   Name="Subtle Emphasis"/>
  <w:LsdException Locked="false" Priority="21" QFormat="true"
   Name="Intense Emphasis"/>
  <w:LsdException Locked="false" Priority="31" QFormat="true"
   Name="Subtle Reference"/>
  <w:LsdException Locked="false" Priority="32" QFormat="true"
   Name="Intense Reference"/>
  <w:LsdException Locked="false" Priority="33" QFormat="true" Name="Book Title"/>
  <w:LsdException Locked="false" Priority="37" SemiHidden="true"
   UnhideWhenUsed="true" Name="Bibliography"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="TOC Heading"/>
  <w:LsdException Locked="false" Priority="41" Name="Plain Table 1"/>
  <w:LsdException Locked="false" Priority="42" Name="Plain Table 2"/>
  <w:LsdException Locked="false" Priority="43" Name="Plain Table 3"/>
  <w:LsdException Locked="false" Priority="44" Name="Plain Table 4"/>
  <w:LsdException Locked="false" Priority="45" Name="Plain Table 5"/>
  <w:LsdException Locked="false" Priority="40" Name="Grid Table Light"/>
  <w:LsdException Locked="false" Priority="46" Name="Grid Table 1 Light"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark"/>
  <w:LsdException Locked="false" Priority="51" Name="Grid Table 6 Colorful"/>
  <w:LsdException Locked="false" Priority="52" Name="Grid Table 7 Colorful"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 1"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 1"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 1"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 1"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 1"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 1"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 1"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 2"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 2"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 2"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 2"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 2"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 2"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 2"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 3"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 3"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 3"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 3"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 3"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 3"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 3"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 4"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 4"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 4"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 4"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 4"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 4"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 4"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 5"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 5"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 5"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 5"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 5"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 5"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 5"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 6"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 6"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 6"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 6"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 6"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 6"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 6"/>
  <w:LsdException Locked="false" Priority="46" Name="List Table 1 Light"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark"/>
  <w:LsdException Locked="false" Priority="51" Name="List Table 6 Colorful"/>
  <w:LsdException Locked="false" Priority="52" Name="List Table 7 Colorful"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 1"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 1"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 1"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 1"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 1"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 1"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 1"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 2"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 2"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 2"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 2"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 2"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 2"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 2"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 3"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 3"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 3"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 3"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 3"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 3"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 3"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 4"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 4"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 4"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 4"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 4"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 4"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 4"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 5"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 5"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 5"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 5"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 5"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 5"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 5"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 6"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 6"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 6"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 6"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 6"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 6"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 6"/>
 </w:LatentStyles>
</xml><![endif]-->
<style>
<!--
 /* Font Definitions */
 @font-face
	{font-family:"Cambria Math";
	panose-1:2 4 5 3 5 4 6 3 2 4;
	mso-font-charset:0;
	mso-generic-font-family:roman;
	mso-font-pitch:variable;
	mso-font-signature:-536869121 1107305727 33554432 0 415 0;}
@font-face
	{font-family:Calibri;
	panose-1:2 15 5 2 2 2 4 3 2 4;
	mso-font-charset:0;
	mso-generic-font-family:swiss;
	mso-font-pitch:variable;
	mso-font-signature:-536859905 -1073732485 9 0 511 0;}
@font-face
	{font-family:Consolas;
	panose-1:2 11 6 9 2 2 4 3 2 4;
	mso-font-charset:0;
	mso-generic-font-family:modern;
	mso-font-pitch:fixed;
	mso-font-signature:-536869121 64767 1 0 415 0;}
 /* Style Definitions */
 p.MsoNormal, li.MsoNormal, div.MsoNormal
	{mso-style-unhide:no;
	mso-style-qformat:yes;
	mso-style-parent:"";
	margin-top:0in;
	margin-right:0in;
	margin-bottom:8.0pt;
	margin-left:0in;
	line-height:107%;
	mso-pagination:widow-orphan;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	mso-ascii-font-family:Calibri;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Calibri;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Calibri;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:"Times New Roman";
	mso-bidi-theme-font:minor-bidi;}
p.MsoListParagraph, li.MsoListParagraph, div.MsoListParagraph
	{mso-style-priority:34;
	mso-style-unhide:no;
	mso-style-qformat:yes;
	margin-top:0in;
	margin-right:0in;
	margin-bottom:8.0pt;
	margin-left:.5in;
	mso-add-space:auto;
	line-height:107%;
	mso-pagination:widow-orphan;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	mso-ascii-font-family:Calibri;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Calibri;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Calibri;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:"Times New Roman";
	mso-bidi-theme-font:minor-bidi;}
p.MsoListParagraphCxSpFirst, li.MsoListParagraphCxSpFirst, div.MsoListParagraphCxSpFirst
	{mso-style-priority:34;
	mso-style-unhide:no;
	mso-style-qformat:yes;
	mso-style-type:export-only;
	margin-top:0in;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:.5in;
	margin-bottom:.0001pt;
	mso-add-space:auto;
	line-height:107%;
	mso-pagination:widow-orphan;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	mso-ascii-font-family:Calibri;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Calibri;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Calibri;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:"Times New Roman";
	mso-bidi-theme-font:minor-bidi;}
p.MsoListParagraphCxSpMiddle, li.MsoListParagraphCxSpMiddle, div.MsoListParagraphCxSpMiddle
	{mso-style-priority:34;
	mso-style-unhide:no;
	mso-style-qformat:yes;
	mso-style-type:export-only;
	margin-top:0in;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:.5in;
	margin-bottom:.0001pt;
	mso-add-space:auto;
	line-height:107%;
	mso-pagination:widow-orphan;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	mso-ascii-font-family:Calibri;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Calibri;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Calibri;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:"Times New Roman";
	mso-bidi-theme-font:minor-bidi;}
p.MsoListParagraphCxSpLast, li.MsoListParagraphCxSpLast, div.MsoListParagraphCxSpLast
	{mso-style-priority:34;
	mso-style-unhide:no;
	mso-style-qformat:yes;
	mso-style-type:export-only;
	margin-top:0in;
	margin-right:0in;
	margin-bottom:8.0pt;
	margin-left:.5in;
	mso-add-space:auto;
	line-height:107%;
	mso-pagination:widow-orphan;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	mso-ascii-font-family:Calibri;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Calibri;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Calibri;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:"Times New Roman";
	mso-bidi-theme-font:minor-bidi;}
span.SpellE
	{mso-style-name:"";
	mso-spl-e:yes;}
span.GramE
	{mso-style-name:"";
	mso-gram-e:yes;}
.MsoChpDefault
	{mso-style-type:export-only;
	mso-default-props:yes;
	font-family:"Calibri",sans-serif;
	mso-ascii-font-family:Calibri;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Calibri;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Calibri;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:"Times New Roman";
	mso-bidi-theme-font:minor-bidi;}
.MsoPapDefault
	{mso-style-type:export-only;
	margin-bottom:8.0pt;
	line-height:107%;}
@page WordSection1
	{size:8.5in 11.0in;
	margin:1.0in 1.0in 1.0in 1.0in;
	mso-header-margin:.5in;
	mso-footer-margin:.5in;
	mso-paper-source:0;}
div.WordSection1
	{page:WordSection1;}
 /* List Definitions */
 @list l0
	{mso-list-id:1263299717;
	mso-list-type:hybrid;
	mso-list-template-ids:-1769439066 67698703 67698713 67698715 67698703 67698713 67698715 67698703 67698713 67698715;}
@list l0:level1
	{mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-.25in;}
@list l0:level2
	{mso-level-number-format:alpha-lower;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-.25in;}
@list l0:level3
	{mso-level-number-format:roman-lower;
	mso-level-tab-stop:none;
	mso-level-number-position:right;
	text-indent:-9.0pt;}
@list l0:level4
	{mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-.25in;}
@list l0:level5
	{mso-level-number-format:alpha-lower;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-.25in;}
@list l0:level6
	{mso-level-number-format:roman-lower;
	mso-level-tab-stop:none;
	mso-level-number-position:right;
	text-indent:-9.0pt;}
@list l0:level7
	{mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-.25in;}
@list l0:level8
	{mso-level-number-format:alpha-lower;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-.25in;}
@list l0:level9
	{mso-level-number-format:roman-lower;
	mso-level-tab-stop:none;
	mso-level-number-position:right;
	text-indent:-9.0pt;}
ol
	{margin-bottom:0in;}
ul
	{margin-bottom:0in;}
-->
</style>
<!--[if gte mso 10]>
<style>
 /* Style Definitions */
 table.MsoNormalTable
	{mso-style-name:"Table Normal";
	mso-tstyle-rowband-size:0;
	mso-tstyle-colband-size:0;
	mso-style-noshow:yes;
	mso-style-priority:99;
	mso-style-parent:"";
	mso-padding-alt:0in 5.4pt 0in 5.4pt;
	mso-para-margin-top:0in;
	mso-para-margin-right:0in;
	mso-para-margin-bottom:8.0pt;
	mso-para-margin-left:0in;
	line-height:107%;
	mso-pagination:widow-orphan;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	mso-ascii-font-family:Calibri;
	mso-ascii-theme-font:minor-latin;
	mso-hansi-font-family:Calibri;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:"Times New Roman";
	mso-bidi-theme-font:minor-bidi;}
</style>
<![endif]--><!--[if gte mso 9]><xml>
 <o:shapedefaults v:ext="edit" spidmax="1026"/>
</xml><![endif]--><!--[if gte mso 9]><xml>
 <o:shapelayout v:ext="edit">
  <o:idmap v:ext="edit" data="1"/>
 </o:shapelayout></xml><![endif]-->
</head>

<body lang=EN-US style='tab-interval:.5in'>

<div class=WordSection1>

<p class=MsoNormal><span style='font-size:13.0pt;line-height:107%'>Steps:<o:p></o:p></span></p>

<p class=MsoNormal><span style='font-size:13.0pt;line-height:107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpFirst style='text-indent:-.25in;mso-list:l0 level1 lfo1'><![if !supportLists]><span
style='font-size:13.0pt;line-height:107%;mso-bidi-font-family:Calibri;
mso-bidi-theme-font:minor-latin'><span style='mso-list:Ignore'>1.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><span
style='font-size:13.0pt;line-height:107%'>Open visual studio and create web
application selecting MVC.<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%;mso-no-proof:yes'><!--[if gte vml 1]><v:shapetype id="_x0000_t75"
 coordsize="21600,21600" o:spt="75" o:preferrelative="t" path="m@4@5l@4@11@9@11@9@5xe"
 filled="f" stroked="f">
 <v:stroke joinstyle="miter"/>
 <v:formulas>
  <v:f eqn="if lineDrawn pixelLineWidth 0"/>
  <v:f eqn="sum @0 1 0"/>
  <v:f eqn="sum 0 0 @1"/>
  <v:f eqn="prod @2 1 2"/>
  <v:f eqn="prod @3 21600 pixelWidth"/>
  <v:f eqn="prod @3 21600 pixelHeight"/>
  <v:f eqn="sum @0 0 1"/>
  <v:f eqn="prod @6 1 2"/>
  <v:f eqn="prod @7 21600 pixelWidth"/>
  <v:f eqn="sum @8 21600 0"/>
  <v:f eqn="prod @7 21600 pixelHeight"/>
  <v:f eqn="sum @10 21600 0"/>
 </v:formulas>
 <v:path o:extrusionok="f" gradientshapeok="t" o:connecttype="rect"/>
 <o:lock v:ext="edit" aspectratio="t"/>
</v:shapetype><v:shape id="Picture_x0020_1" o:spid="_x0000_i1030" type="#_x0000_t75"
 style='width:212.25pt;height:304.5pt;visibility:visible;mso-wrap-style:square'>
 <v:imagedata src="Images/image001.png"
  o:title=""/>
</v:shape><![endif]--><![if !vml]><img width=283 height=406
src="Images/image001.png"
v:shapes="Picture_x0020_1"><![endif]></span><span style='font-size:13.0pt;
line-height:107%'><o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-.25in;mso-list:l0 level1 lfo1'><![if !supportLists]><span
style='font-size:13.0pt;line-height:107%;mso-bidi-font-family:Calibri;
mso-bidi-theme-font:minor-latin'><span style='mso-list:Ignore'>2.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><span
style='font-size:13.0pt;line-height:107%'>Run the application. while running
application in visual studio 2017 community, you can see below screen, if not
jump to next step.<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%;mso-no-proof:yes'><!--[if gte vml 1]><v:shape id="Picture_x0020_2" o:spid="_x0000_i1029"
 type="#_x0000_t75" style='width:468pt;height:168.75pt;visibility:visible;
 mso-wrap-style:square'>
 <v:imagedata src="Images/image002.png"
  o:title=""/>
</v:shape><![endif]--><![if !vml]><img width=624 height=225
src="Images/image003.jpg"
v:shapes="Picture_x0020_2"><![endif]></span><span style='font-size:13.0pt;
line-height:107%'><o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>So wait until the application get loads, it was taking too much time so
you can disable it from tools-&gt;options-&gt;debugging and uncheck the item<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%;mso-no-proof:yes'><!--[if gte vml 1]><v:shape id="Picture_x0020_3" o:spid="_x0000_i1028"
 type="#_x0000_t75" style='width:468pt;height:261pt;visibility:visible;
 mso-wrap-style:square'>
 <v:imagedata src="Images/image004.png"
  o:title=""/>
</v:shape><![endif]--><![if !vml]><img width=624 height=348
src="Images/image005.jpg"
v:shapes="Picture_x0020_3"><![endif]></span><span style='font-size:13.0pt;
line-height:107%'><o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-.25in;mso-list:l0 level1 lfo1'><![if !supportLists]><span
style='font-size:13.0pt;line-height:107%;mso-bidi-font-family:Calibri;
mso-bidi-theme-font:minor-latin'><span style='mso-list:Ignore'>3.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><span
style='font-size:13.0pt;line-height:107%'>Once application loaded you can see<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%;mso-no-proof:yes'><!--[if gte vml 1]><v:shape id="Picture_x0020_4" o:spid="_x0000_i1027"
 type="#_x0000_t75" style='width:468pt;height:233.25pt;visibility:visible;
 mso-wrap-style:square'>
 <v:imagedata src="Images/image006.png"
  o:title=""/>
</v:shape><![endif]--><![if !vml]><img width=624 height=311
src="Images/image007.jpg"
v:shapes="Picture_x0020_4"><![endif]></span><span style='font-size:13.0pt;
line-height:107%'><o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-.25in;mso-list:l0 level1 lfo1'><![if !supportLists]><span
style='font-size:13.0pt;line-height:107%;mso-bidi-font-family:Calibri;
mso-bidi-theme-font:minor-latin'><span style='mso-list:Ignore'>4.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><span
style='font-size:13.0pt;line-height:107%'>Install “</span><span class=SpellE><span
class=GramE><span style='font-size:13.0pt;line-height:107%;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>SimpleInjector.Integration.Web.Mvc</span></span></span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'>”</span><span style='font-size:13.0pt;line-height:107%'> <span
style='mso-spacerun:yes'> </span>package from nugget, it will install all
dependencies. <span class=SpellE>Packages.config</span> file will have now
entries <o:p></o:p></span></p>

<p class=MsoListParagraphCxSpLast><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;text-indent:
.5in;line-height:normal;mso-layout-grid-align:none;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>&lt;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:#A31515'>package</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'> </span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:red'>id</span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span class=SpellE><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>SimpleInjector</span></span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'> </span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:red'>version</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>=</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'>&quot;</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>4.2.2</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'> </span><span class=SpellE><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:red'>targetFramework</span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>net461</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'> /&gt;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:46.5pt;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>&lt;</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:#A31515'>package</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'> </span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:red'>id</span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span class=SpellE><span class=GramE><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>SimpleInjector.Integration.Web</span></span></span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'> </span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:red'>version</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>=</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'>&quot;</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>4.2.2</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'> </span><span class=SpellE><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:red'>targetFramework</span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>net461</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'> /&gt;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:46.5pt;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:46.5pt;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>&lt;</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:#A31515'>package</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'> </span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:red'>id</span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span class=SpellE><span class=GramE><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>SimpleInjector.Integration.Web.Mvc</span></span></span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'> </span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:red'>version</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>=</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'>&quot;</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>4.2.2</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'> </span><span class=SpellE><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:red'>targetFramework</span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>&quot;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>net461</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'> /&gt;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:46.5pt;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpFirst style='text-indent:-.25in;mso-list:l0 level1 lfo1'><![if !supportLists]><span
style='font-size:13.0pt;line-height:107%;mso-bidi-font-family:Calibri;
mso-bidi-theme-font:minor-latin'><span style='mso-list:Ignore'>5.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><span
style='font-size:13.0pt;line-height:107%'>Add two projects “<span class=SpellE>DataAccess</span>”
and “<span class=SpellE>EntityModel</span>”. <span class=SpellE>Dataaccess</span>
is for interacting with database and entity model will contains entities. Add
references of these projects in “App” project<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%;mso-no-proof:yes'><!--[if gte vml 1]><v:shape id="Picture_x0020_5" o:spid="_x0000_i1026"
 type="#_x0000_t75" style='width:253.5pt;height:63.75pt;visibility:visible;
 mso-wrap-style:square'>
 <v:imagedata src="Images/image008.png"
  o:title=""/>
</v:shape><![endif]--><![if !vml]><img width=338 height=85
src="Images/image008.png"
v:shapes="Picture_x0020_5"><![endif]></span><span style='font-size:13.0pt;
line-height:107%'><o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-.25in;mso-list:l0 level1 lfo1'><![if !supportLists]><span
style='font-size:13.0pt;line-height:107%;mso-bidi-font-family:Calibri;
mso-bidi-theme-font:minor-latin'><span style='mso-list:Ignore'>6.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><span
style='font-size:13.0pt;line-height:107%'>In <span class=SpellE>DataAccess</span>
layer, create one folder “Interface” and interface file “</span><span
class=SpellE><span style='font-size:13.0pt;line-height:107%;font-family:Consolas;
mso-bidi-font-family:Consolas;color:#2B91AF'>ICompanyRepository.cs</span></span><span
style='font-size:13.0pt;line-height:107%'>”<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpLast><span style='font-size:13.0pt;line-height:
107%'>File contents:<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>namespace</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=SpellE>DataAccess.Interface</span><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span></span><span style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'>public</span><span style='font-size:13.0pt;font-family:
Consolas;mso-bidi-font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>interface</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> </span><span class=SpellE><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:#2B91AF'>ICompanyRepository</span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>List&lt;Company&gt; <span class=SpellE><span
class=GramE>GetCompanies</span></span><span class=GramE>(</span>);<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span>}<o:p></o:p></span></p>

<p class=MsoNormal style='text-indent:.5in'><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>}<o:p></o:p></span></p>

<p class=MsoNormal style='text-indent:.5in'><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpFirst><span style='font-size:13.0pt;line-height:
107%'>Now, create “Repository” folder and add class file “<span class=SpellE>CompanySqlRepository.cs</span>”.
Implement interface and created the constructor to inject <span class=SpellE>IDbConnection</span>
which will return <span class=SpellE>sqlconnection</span>. <o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>To check <span class=SpellE>IDbConnection</span>, I am just going to open
<span class=SpellE>sql</span> connection and getting it close.<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>Add your <span class=SpellE>sql</span> connection string in <span
class=SpellE>web.config</span> file<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>&lt;</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;mso-bidi-font-family:
Consolas;color:#A31515'>add</span><span style='font-size:13.0pt;line-height:
107%;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'> </span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;mso-bidi-font-family:
Consolas;color:red'>name</span><span style='font-size:13.0pt;line-height:107%;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>=</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;mso-bidi-font-family:
Consolas;color:black'>&quot;</span><span class=SpellE><span style='font-size:
13.0pt;line-height:107%;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>mssql</span></span><span style='font-size:13.0pt;line-height:107%;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'> </span><span class=SpellE><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;mso-bidi-font-family:Consolas;color:red'>connectionString</span></span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'>=</span><span style='font-size:13.0pt;line-height:107%;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'>Data Source=#<span class=SpellE>DataSourceName</span>#;
Integrated Security=<span class=SpellE><span class=GramE>True;User</span></span>
ID=<span class=SpellE>sa</span>; Password=#password#; Initial Catalog=#<span
class=SpellE>DatabaseName</span>#;</span><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>&quot;</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'> /&gt;<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpLast><span style='font-size:13.0pt;line-height:
107%'>File contents:<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE><span class=GramE>System.Collections.Generic</span></span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE>System.Data</span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE>DataAccess.Interface</span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE>EntityModel.DomainModel</span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE>System.Configuration</span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>namespace</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=SpellE><span class=GramE>DataAccess.Repository.Dapper.MSSQL</span></span><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span></span><span style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'>public</span><span style='font-size:13.0pt;font-family:
Consolas;mso-bidi-font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>class</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> </span><span class=SpellE><span
class=GramE><span style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:
Consolas;color:#2B91AF'>CompanySqlRepository</span></span></span><span
class=GramE><span style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:
Consolas;color:black'> :</span></span><span style='font-size:13.0pt;font-family:
Consolas;mso-bidi-font-family:Consolas;color:black'> <span class=SpellE>ICompanyRepository</span><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>private</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=SpellE>IDbConnection</span> _connection;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=SpellE><span class=GramE>CompanySqlRepository</span></span><span
class=GramE>(</span><span class=SpellE>IDbConnection</span> conn)<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span>_connection = conn;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span>_<span class=SpellE><span
class=GramE>connection.ConnectionString</span></span> =
ConfigurationManager.ConnectionStrings[</span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:#A31515'>&quot;mssql&quot;</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'>].ConnectionString;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>}<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> List&lt;Company&gt; <span class=SpellE><span class=GramE>GetCompanies</span></span><span
class=GramE>(</span>)<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span style='background:yellow;
mso-highlight:yellow'>_<span class=SpellE><span class=GramE>connection.Open</span></span>();</span><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span style='background:yellow;
mso-highlight:yellow'>_<span class=SpellE><span class=GramE>connection.Close</span></span>();</span><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span></span><span class=SpellE><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>var</span></span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> <span class=SpellE>lstCompany</span>
= </span><span style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'>new</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> List&lt;Company<span class=GramE>&gt;(</span>)<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>                </span></span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=GramE>Company{</span>Id=1, Name=</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:#A31515'>&quot;Microsoft&quot;</span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> },<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>                </span></span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=GramE>Company{</span>Id=2, Name=</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:#A31515'>&quot;Google&quot;</span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> },<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>                </span></span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=GramE>Company{</span>Id=3, Name=</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:#A31515'>&quot;Facebook&quot;</span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> },<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>                </span></span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=GramE>Company{</span>Id=4, Name=</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:#A31515'>&quot;Tesla&quot;</span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> },<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>                </span></span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>new</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=GramE>Company{</span>Id=5, Name=</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:#A31515'>&quot;HP&quot;</span><span style='font-size:13.0pt;font-family:
Consolas;mso-bidi-font-family:Consolas;color:black'> }<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span>};<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>    
</span><span style='mso-spacerun:yes'>       </span></span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>return</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> <span class=SpellE>lstCompany</span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>}<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span>}<o:p></o:p></span></p>

<p class=MsoNormal style='text-indent:.5in'><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>}<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpFirst style='text-indent:-.25in;mso-list:l0 level1 lfo1'><![if !supportLists]><span
style='font-size:13.0pt;line-height:107%;mso-bidi-font-family:Calibri;
mso-bidi-theme-font:minor-latin'><span style='mso-list:Ignore'>7.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><span
style='font-size:13.0pt;line-height:107%'>Create “</span><span class=SpellE><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;mso-bidi-font-family:
Consolas;color:#2B91AF'>ApplicationDependencyResolver.cs</span></span><span
style='font-size:13.0pt;line-height:107%'>” file under <span class=SpellE>App_start</span>
folder and add namespace “</span><span style='font-size:13.0pt;line-height:
107%;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>using</span><span
style='font-size:13.0pt;line-height:107%;font-family:Consolas;mso-bidi-font-family:
Consolas;color:black'> <span class=SpellE>SimpleInjector</span>;”</span><span
style='font-size:13.0pt;line-height:107%'>. Mark class as static and will start
creating method which contains all dependencies related to project.<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'>Here we are going to add dependencies for <span class=SpellE>IDbConnection</span>
and <span class=SpellE>ICompanyRepository</span>, before this it’s important to
Register MVC Controllers and Filter Providers.<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpLast><span style='font-size:13.0pt;line-height:
107%'>Code:<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE>DataAccess.Interface</span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE><span class=GramE>DataAccess.Repository.Dapper.MSSQL</span></span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE>SimpleInjector</span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE>System.Configuration</span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE>System.Data</span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE><span class=GramE>System.Data.SqlClient</span></span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>namespace</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=SpellE>App.App_Start</span><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span></span><span style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'>Public static</span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>class</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> </span><span class=SpellE><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:#2B91AF'>ApplicationDependencyResolver</span></span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> </span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>static</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>void</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> <span class=SpellE><span
class=GramE>RegisterApplicationDependencies</span></span><span class=GramE>(</span>Container
container)<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE><span
class=GramE>container.RegisterMvcControllers</span></span>();<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE><span
class=GramE>container.RegisterMvcIntegratedFilterProvider</span></span>();<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:99.0pt;margin-bottom:.0001pt;text-indent:-63.0pt;line-height:normal;
mso-layout-grid-align:none;text-autospace:none'><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE><span
class=GramE>container.Register</span></span>&lt;<span class=SpellE>ICompanyRepository</span>,
<span class=SpellE>CompanySqlRepository</span>&gt;(<span class=SpellE>Lifestyle.Scoped</span>);<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:99.0pt;margin-bottom:.0001pt;text-indent:-63.0pt;line-height:normal;
mso-layout-grid-align:none;text-autospace:none'><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:99.0pt;margin-bottom:.0001pt;text-indent:-63.0pt;line-height:normal;
mso-layout-grid-align:none;text-autospace:none'><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE><span
class=GramE>container.Register</span></span>&lt;<span class=SpellE>IDbConnection</span>&gt;(()
=&gt; </span><span style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'>new</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'>
SqlConnection(ConfigurationManager.ConnectionStrings[</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:#A31515'>&quot;mssql&quot;</span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>].ConnectionString),
<span class=SpellE>Lifestyle.Scoped</span>);<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>}<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span>}<o:p></o:p></span></p>

<p class=MsoNormal style='margin-left:.5in'><span style='font-size:13.0pt;
line-height:107%;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>}</span><span
style='font-size:13.0pt;line-height:107%'><o:p></o:p></span></p>

<p class=MsoNormal><span style='font-size:13.0pt;line-height:107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpFirst><span style='font-size:13.0pt;line-height:
107%;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpMiddle style='text-indent:-.25in;mso-list:l0 level1 lfo1'><![if !supportLists]><span
style='font-size:13.0pt;line-height:107%;mso-bidi-font-family:Calibri;
mso-bidi-theme-font:minor-latin'><span style='mso-list:Ignore'>8.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><span
style='font-size:13.0pt;line-height:107%'>Next step to initialize injector, create
new <span class=GramE>file <span style='mso-spacerun:yes'> </span>“</span></span><span
class=SpellE><span style='font-size:13.0pt;line-height:107%;font-family:Consolas;
mso-bidi-font-family:Consolas;color:#2B91AF'>SimpleInjectorWebInitializer.cs</span></span><span
style='font-size:13.0pt;line-height:107%'>” and mark class as static.<span
style='mso-spacerun:yes'>  </span>It is must to define “<span class=SpellE>DefaultScopedLifeStyle</span>”
else it will throw error. <span style='mso-spacerun:yes'> </span>If you want to
add <span class=SpellE>comman</span> dependencies throughout the application like
logger or cache, then register as singleton. I have created method for it. As
of now it is commented. Let’s focus on interface <span class=SpellE>ICompanyRepository</span>
injection.<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle><span style='font-size:13.0pt;line-height:
107%'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpLast><span style='font-size:13.0pt;line-height:
107%'>File contents:<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE>SimpleInjector</span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE><span class=GramE>SimpleInjector.Integration.Web</span></span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> System;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE><span class=GramE>System.Web.Mvc</span></span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE><span class=GramE>SimpleInjector.Integration.Web.Mvc</span></span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:green'>//add assembly <span class=SpellE><span
class=GramE>System.Runtime.Caching</span></span> for it</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE><span class=GramE>System.Runtime.Caching</span></span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>using</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>
log4net;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>namespace</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=SpellE>App.App_Start</span><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span></span><span style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'>public</span><span style='font-size:13.0pt;font-family:
Consolas;mso-bidi-font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>static</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> </span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>class</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> </span><span class=SpellE><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:#2B91AF'>SimpleInjectorWebInitializer</span></span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> </span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>static</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>void</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> <span class=SpellE>InitilizeContainer</span>(Action&lt;Container&gt;
<span class=SpellE>registerApplicationDependencies</span>)<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE>GetInitializeContainer</span>(<span
class=SpellE>registerApplicationDependencies</span>);<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>}<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>public</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> </span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>static</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>
Container <span class=SpellE>GetInitializeContainer</span>(Action&lt;Container&gt;
<span class=SpellE>registerApplicationDependencies</span>)<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span></span><span class=SpellE><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>var</span></span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> container = </span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>new</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> <span class=GramE>Container(</span>);<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=GramE>Initialize(</span>container,
<span class=SpellE>registerApplicationDependencies</span>);<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>return</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> container;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>}<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>private</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> </span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>static</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>void</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> <span class=GramE>Initialize(</span>Container
<span class=SpellE>container</span>, Action&lt;Container&gt; <span
class=SpellE>registerApplicationDependencies</span>)<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE><span
class=GramE>container.Options.DefaultScopedLifestyle</span></span> = </span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>new</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> <span class=SpellE>WebRequestLifestyle</span>();<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE>RegisterCommandDependencies</span>(container);<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE>registerApplicationDependencies.Invoke</span>(container);<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE>DependencyResolver.SetResolver</span>(</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>new</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> <span class=SpellE>SimpleInjectorDependencyResolver</span>(container));<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>}<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:gray'>///</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:green'> </span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:gray'>&lt;summary&gt;</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:gray'>///</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:green'> This class is to register <span class=SpellE>commandepencies</span>
<span class=SpellE>through out</span> the application, like logger, cache</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:gray'>///</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:green'> </span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:gray'>&lt;/summary&gt;</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>private</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> </span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>static</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> </span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>void</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'> <span class=SpellE><span
class=GramE>RegisterCommandDependencies</span></span><span class=GramE>(</span>Container
container)<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:green'>//<span
class=SpellE><span class=GramE>container.RegisterSingleton</span></span>&lt;<span
class=SpellE>ObjectCache</span>&gt;(<span class=SpellE>MemoryCache.Default</span>);</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:green'>//<span
class=SpellE><span class=GramE>container.RegisterSingleton</span></span>&lt;<span
class=SpellE>ILog</span>&gt;(<span class=SpellE>LogManager.GetLogger</span>(&quot;&quot;));</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>}<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span>}<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'>}</span><span style='font-size:13.0pt'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpFirst style='text-indent:-.25in;mso-list:l0 level1 lfo1'><![if !supportLists]><span
style='font-size:13.0pt;line-height:107%;mso-bidi-font-family:Calibri;
mso-bidi-theme-font:minor-latin'><span style='mso-list:Ignore'>9.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><span
style='font-size:13.0pt;line-height:107%'>Final step to call Initialize from <span
class=SpellE>Global.asax</span> file<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpLast style='margin-bottom:0in;margin-bottom:.0001pt;
mso-add-space:auto;line-height:normal;mso-layout-grid-align:none;text-autospace:
none'><span style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:
Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>protected</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> </span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>void</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> <span
class=SpellE>Application_<span class=GramE>Start</span></span><span
class=GramE>(</span>)<o:p></o:p></span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none'><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none'><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE>AreaRegistration.RegisterAllAreas</span>();<o:p></o:p></span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none'><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:63.0pt;margin-bottom:.0001pt;text-indent:-63.0pt;line-height:normal;
mso-layout-grid-align:none;text-autospace:none'><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span>Action&lt;Container&gt; <span
class=SpellE>registerApplictionDependencies</span> = <span class=SpellE>ApplicationDependencyResolver.RegisterApplicationDependencies</span>;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:63.0pt;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>           
</span>SimpleInjectorWebInitializer.InitilizeContainer(registerApplictionDependencies);<o:p></o:p></span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none'><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none'><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE>FilterConfig.RegisterGlobalFilters</span>(<span
class=SpellE>GlobalFilters.Filters</span>);<o:p></o:p></span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none'><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE>RouteConfig.RegisterRoutes</span>(<span
class=SpellE>RouteTable.Routes</span>);<o:p></o:p></span></p>

<p class=MsoNormal style='margin-bottom:0in;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none'><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>            </span><span class=SpellE>BundleConfig.RegisterBundles</span>(<span
class=SpellE>BundleTable.Bundles</span>);<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpFirst style='margin-top:0in;margin-right:0in;
margin-bottom:0in;margin-left:.25in;margin-bottom:.0001pt;mso-add-space:auto;
line-height:normal;mso-layout-grid-align:none;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'><span style='mso-spacerun:yes'>     </span>}<o:p></o:p></span></p>

<p class=MsoListParagraphCxSpMiddle style='margin-top:0in;margin-right:0in;
margin-bottom:0in;margin-left:.25in;margin-bottom:.0001pt;mso-add-space:auto;
line-height:normal;mso-layout-grid-align:none;text-autospace:none'><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpLast style='margin-bottom:0in;margin-bottom:.0001pt;
mso-add-space:auto;text-indent:-.25in;line-height:normal;mso-list:l0 level1 lfo1;
mso-layout-grid-align:none;text-autospace:none'><![if !supportLists]><span
style='font-size:13.0pt;font-family:Consolas;mso-fareast-font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-list:Ignore'>10.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><![endif]><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'>Open <span class=SpellE>Index.cshtml</span>
in views folder and add following code to list companies name<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>&lt;</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:maroon'>div</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>&gt;</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span><span style='background:yellow;mso-highlight:yellow'>@</span></span><span
class=SpellE><span style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:
Consolas;color:blue'>foreach</span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'> (<span
class=SpellE>var</span> item </span><span style='font-size:13.0pt;font-family:
Consolas;mso-bidi-font-family:Consolas;color:blue'>in</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'> <span class=SpellE>ViewBag.Companies</span>)<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span>{<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span
style='mso-spacerun:yes'>        </span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>&lt;</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:maroon'>li</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>&gt;</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:black;
background:yellow;mso-highlight:yellow'>@</span><span class=SpellE><span
class=GramE><span style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:
Consolas;color:black'>item.Id</span></span></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'>: <span
style='background:yellow;mso-highlight:yellow'>@</span><span class=SpellE>item.Name</span></span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>&lt;/</span><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:maroon'>li</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:blue'>&gt;</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:black'><o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-spacerun:yes'>   
</span>}<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'>&lt;/</span><span style='font-size:
13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;color:maroon'>div</span><span
style='font-size:13.0pt;font-family:Consolas;mso-bidi-font-family:Consolas;
color:blue'>&gt;<o:p></o:p></span></p>

<p class=MsoNormal style='margin-top:0in;margin-right:0in;margin-bottom:0in;
margin-left:.5in;margin-bottom:.0001pt;line-height:normal;mso-layout-grid-align:
none;text-autospace:none'><span style='font-size:13.0pt;font-family:Consolas;
mso-bidi-font-family:Consolas;color:blue'><o:p>&nbsp;</o:p></span></p>

<p class=MsoListParagraphCxSpFirst style='margin-bottom:0in;margin-bottom:.0001pt;
mso-add-space:auto;text-indent:-.25in;line-height:normal;mso-list:l0 level1 lfo1;
mso-layout-grid-align:none;text-autospace:none'><![if !supportLists]><span
style='font-size:13.0pt;font-family:Consolas;mso-fareast-font-family:Consolas;
mso-bidi-font-family:Consolas;color:black'><span style='mso-list:Ignore'>11.<span
style='font:7.0pt "Times New Roman"'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</span></span></span><![endif]><span style='font-size:13.0pt'>Run application
and it will show list of companies</span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><o:p></o:p></span></p>

<p class=MsoListParagraphCxSpLast style='margin-bottom:0in;margin-bottom:.0001pt;
mso-add-space:auto;line-height:normal;mso-layout-grid-align:none;text-autospace:
none'><span style='font-size:13.0pt;mso-no-proof:yes'><!--[if gte vml 1]><v:shape
 id="Picture_x0020_6" o:spid="_x0000_i1025" type="#_x0000_t75" style='width:467.25pt;
 height:214.5pt;visibility:visible;mso-wrap-style:square'>
 <v:imagedata src="Images/image009.png"
  o:title=""/>
</v:shape><![endif]--><![if !vml]><img width=623 height=286
src="Images/image010.jpg"
v:shapes="Picture_x0020_6"><![endif]></span><span style='font-size:13.0pt;
font-family:Consolas;mso-bidi-font-family:Consolas;color:black'><o:p></o:p></span></p>

</div>

</body>

</html>