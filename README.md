# furry-dangerzone

Testing out new git lfs!! 

If you want to clone this repo, then you'll need to download a [Client Plugin](https://github.com/github/git-lfs/releases).  Just download your OS binary, extract it and run the install script from anywhere.

What to know about git lfs workeflow? [Read it here](https://git-lfs.github.com/)

For example, if you want to track a new file format (like psd) you'd do something like this...
```bash
git lfs track "*.psd"

git add file.psd
git commit -m "Add design file"
git push origin master
```

You'll see all the file formats tracked via lfs in .gitattributes.  Or you can use the command line tool (git lfs ls-files) to show what files lfs is currently tracking.

purposely causing another conflict!
