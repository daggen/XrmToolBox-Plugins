# Deprecated
I'm no longer active professional in the Dynamics community. Hence I will not be actively working and maintaining this anymore.

# Plugin: User, Team and Security Role Report
View User's and Team's Security Roles and how they related to each other. Also possible to bulk update!

## Operations

* View relationships between users/teams and security roles
* View which roles which has all the selected roles
* View which roles has at least one of the selected roles
* Add/remove selected roles to selected users/teams
* Export all current mapping of users/teams and security roles

## View
- Single click on either user/team or security role will filter the other list to which uses this, i.e. click on a user to see which roles are currently assigned or click on a security role to see which users/teams has it.
- Use selected box on either user/team or security role for filter with combine (OR) or Intersect (AND) conditions. The radio buttons determines direction for filtering.
- Double click a user/team or security role to open corresponding record in Dynamics. 

## Add/Remove security roles
By selecting checkbox for a set of users/teams and security roles you may add or remove the specified mapping. If you try to remove a role which the users/team doesn't have then it will be ignored for that specific user/team. Likewise if you try to add roles to a user/team which already are present. After operation you will see number of updates done.

## Report of current mapping
Will save two files for you. One is a CSV file with all users/teams with business unit and type listed with all their assigned roles. If there exist users without any role they will not be present in this list. Likewise if there exist role which have not been assigned. The excel file is can be used to aggregate the csv file and display the same data. Follow instruction in excel file for including the data. (Room for improvement for the willing developer).
