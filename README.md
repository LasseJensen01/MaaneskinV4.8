**How to take a task and branch off main**

***1:***

Locate task and attach youself on trello. Take note of the task ID.![Udklip](https://github.com/user-attachments/assets/5a916d5e-5d16-4ce8-9b1b-3a1646d02d3f)

***2:***
Now open the project in Visual Studio and pull from origin/main to make sure your master is up to date.
![Udklip](https://github.com/user-attachments/assets/96dbcf08-1709-4bb5-8ce2-0db56317f26b)

Or here.

![Udklip](https://github.com/user-attachments/assets/5b55f423-d892-4b73-9c9e-50cf6626ee5c)

***3:***
Now branch up from master and name your branch the ID of your task so in this instance US1-2.

![Udklip](https://github.com/user-attachments/assets/d0115409-a090-40e4-929e-e9a693102350)

Or here.

![Udklip](https://github.com/user-attachments/assets/91586629-577a-4ca1-815b-51322e84b76a)


![Udklip](https://github.com/user-attachments/assets/62dea348-8a45-4fc2-8b69-61bb492c1714)

By doing this we are able to identify each task and branch by their ID which could streamline code review 😎.

***4:***
Now simply start completing the task and when its ready for review push it up to git.
***5***
To merge your branch into master will require either a pull request or for you to accept the sweet and cold embrace of GIT Powershell commands. Lets start with pull requests.

In order to create a pull request make sure you have commited and pushed your changes on your branch.
Now checkout to your master and pull and navigate to GIT -> GitHub -> New Pull Request in your toolbar.

![Udklip](https://github.com/user-attachments/assets/ad3ccd2c-5808-4413-b770-8656a5e54836)

Here make sure your "Merge into:" is mentioning origin/master and your "From" is mentioning your branch like so.

![Udklip](https://github.com/user-attachments/assets/97e6bca5-6d90-4a14-b2d7-3a325fc75b8b)

Make sure to have pushed your branch as the origin/"Branch name" relates to the branch on Github.

From here you are able to see the changes made and in which files. Make sure the title is filled in, make the name related to your branch.

From here just hit Create

You will get a confirmation message like this

![Udklip](https://github.com/user-attachments/assets/4b3eead3-5f3d-4297-b086-cc07738f3c24)

If you click underlined link you will be navigated to our GitHub repo where the you may accept the request

![Udklip](https://github.com/user-attachments/assets/faf29b57-bc3b-4764-9da3-cd9907b8ceee)

We may choose to use the pull request as a way to do code review so make sure to notify whoever is supposed to do that. They will be able to see the changes in the circled commits or by checking out to the related branch and manually going over the code.

If everything checks out, hit "Merge pull request" and Confirm it. Git will then automatically merge the branch into origin/master. Make sure to pull on your own master to verify.
