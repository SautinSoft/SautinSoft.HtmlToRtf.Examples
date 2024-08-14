# Execute docker commands from project's folder

```cmd
:: 1. Create docker image named "htmltortfimage".
docker build -t htmltortfimage -f Dockerfile .

:: 2. Create and start docker container named "htmltortfcontainer".
docker run --name htmltortfcontainer htmltortfimage

:: 3. Copy output files from container to project's folder.
docker cp htmltortfcontainer:/app/sample.html .
docker cp htmltortfcontainer:/app/sample.rtf .

:: 4. Clean up, remove container and image.
docker container rm htmltortfcontainer
docker image rm htmltortfimage
```