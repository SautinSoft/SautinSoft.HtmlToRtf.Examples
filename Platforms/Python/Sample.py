import sys
import clr
import os

# Before starting, we recommend to get a free key:
# https://sautinsoft.com/start-for-free/
# Please check that you're using the current versions of components and necessary dependencies for successful operation.
# The latest versions are here: :https://www.nuget.org/packages/SautinSoft.HtmlToRtf/

clr.AddReference(os.path.abspath("net471/System.Runtime.CompilerServices.Unsafe.dll"))
clr.AddReference(os.path.abspath("net471/System.Numerics.Vectors.dll"))
clr.AddReference(os.path.abspath("net471/System.Buffers.dll"))
clr.AddReference(os.path.abspath("net471/System.Memory.dll"))
clr.AddReference(os.path.abspath("net471/ExCSS.dll"))
clr.AddReference(os.path.abspath("net471/Svg.Custom.dll"))
clr.AddReference(os.path.abspath("net471/ShimSkiaSharp.dll"))
clr.AddReference(os.path.abspath("net471/Svg.Model.dll"))
clr.AddReference(os.path.abspath("net471/HarfBuzzSharp.dll"))
clr.AddReference(os.path.abspath("net471/SkiaSharp.HarfBuzz.dll"))
clr.AddReference(os.path.abspath("net471/Svg.Skia.dll"))
clr.AddReference(os.path.abspath("net471/System.Security.Cryptography.Algorithms.dll"))
clr.AddReference(os.path.abspath("net471/System.Security.SecureString.dll"))
clr.AddReference(os.path.abspath("net471/System.Net.Http.dll"))
clr.AddReference(os.path.abspath("net471/System.Runtime.CompilerServices.Unsafe.dll"))
clr.AddReference(os.path.abspath("net471/SautinSoft.HtmlToRtf.dll"))

# Convert HTML file to Word file

import SautinSoft
from SautinSoft import HtmlToRtf
dc = HtmlToRtf()
dc.Convert(os.path.abspath("Sample.html"), os.path.abspath("Sample.rtf"), HtmlToRtf.HtmlConvertOptions())

print("Conversion was successful.")