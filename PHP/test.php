<?php

$h = new COM("SautinSoft.HtmlToRtf");

/* Convert HTML file to RTF file */
$result = $h->ConvertFile("d:\\Source.html", "d:\\Copy.rtf");

if ($result==0)
{
	/* Open RTF in WordPad or MS Word */
}
else
	print("Converting failed!");

?>