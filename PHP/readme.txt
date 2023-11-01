Here we'll show the steps How to use HTML to RTF .Net in PHP.
------------------------------------------------------------------
Automatic way:

1. To make all manual steps at once, launch the start.bat

------------------------------------------------------------------
Manual steps:

1. Add the SautinSoft.HtmlToRtf.dll to the GAC, launch:

	gacutil.exe /i "..\..\Bin\.NET Framework 4.6\SautinSoft.HtmlToRtf.dll"
	
2. Add the Assembly to the Registry, launch:

	Regasm "..\..\Bin\.NET Framework 4.6\SautinSoft.HtmlToRtf.dll" /tlb:SautinSoft.HtmlToRtf.tlb
	
3. Now you may use the component in PHP.

   First you may try our "test.php". Copy the file "test.php" at your localhost directory, next open a browser and type:
   http://localhost/test.php
------------------------------------------------------------------
What's is "gacutil.exe" and "RegAsm.exe"?

gacutil.exe - Global Assembly Cache Tool: http://msdn.microsoft.com/en-us/library/ex0ss12c%28v=vs.80%29.aspx
RegAsm.exe - Assembly Registration Tool: http://msdn.microsoft.com/en-us/library/tzat5yw6%28v=vs.71%29.aspx

If you have any questions, ask us online at: http://www.sautinsoft.com or email: support@sautinsoft.com	

