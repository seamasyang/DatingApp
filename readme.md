
asp.net core api & angular spa


-- add to git (git-scm.com)

by default, angular will add git, and list changes for you.

steps to add to signle git repositor
got the root folder
- git status
- windows exploer, delete .git (created by angular) folder if there is
- git status again->no repository
- update .gitignore if needed
- git init -> all changes will be listed there (api & spa), add comment for changes, for example "first commit", changes are saved locally
- git remote add origin "git url"
- git push -u origin master
------------optional--------------------
[ssh key need for windows]
1) generate ssh key: 
  - 1)A, ssh-keygen -t rsa -b 4096 -C "your.mail.address"
  - 1)B, eval $(ssh-agent -s)
  - 1)C, ssh-add ~/.ssh/id_rsa
2) add to git account
3) git push -u origin master
4) check on github
