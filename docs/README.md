# Ally Local

This program is inspired from Ally program developed by **Alicia Hock**. It is to be used by students who are taking **38PROG** module. 

This program is to be installed in students' computers.

* It provides basic feature for students to create c files, compile and run them.
* Students will use it to complete exercises in class.
* It is the centralize location for teachers to check students' work. 



## 1. How it Works?

### 1.1 Exercises Types

There are 2 types of exercises, **compulsory exercises** and **additional exercises**. 

* **Compulsory Exercises:** List of compulsory exercises which students must complete. 
* **Additional Exercises:** List of additional exercises which teachers may ask students to practice.

Upon running the program the first time, a **"exercises"** folder will be created in **"c:\Users\<USERNAME>\AppData\Roaming\AllyLocal\"** folder. It typically contains 2 subfolders, **"additional"** and **"compulsory"**. 

Module leader can use the file **"exercises/compulsory/files.lst"** to specify list of compulsory exercises which students must complete. Based on the **"files.lst"** file, empty files will be created. 

### 1.2 Encryption

Upon first launch, student will be asked for his name. All exercise files will be encrypted using lower case of student's name. 



## 2. Features

### 2.1 Compulsory Exercise List

- Generate list of Compulsory Exercises from text file

### 2.2 Additional Exercise List

- Allow user to create new file to Additional Exercises list
- Allow user to delete existing file from Additional Exercises list
- Allow user to rename an existing file from Additional Exercises list
- Allow user to load existing files into AllyLocal. User can drag and drop multiple files to add files to Additional Exercises list.

### 2.3 Code Editor

User can select a file from Compulsory Exercises list or Additional Exercises list. File will be open editor for editing. 

#### Auto Save

When user select another file, modification to previous file will be automatically saved.

### 2.4 Compile and Run

* User can compile and run any file from the file list
* Compile output will be shown at output pane
* New command line prompt will be launched when a file is run

### 2.5 Shortcut Keys

Shortcut keys are added for convenience.

*  `CTRL+C`: Compile current file
* `CTRL+R`: Run current file
* `CTRL+N`: Create a new file
* `CTRL+L`: Load an existing file
* `CTRL+S`: Save current file

#### Disable Copy and Paste

Copy and Paste shortcut keys are disabled to force students to type their exercise. 

- `CTRL+V`: Disabled

### 2.6 Tool Tips

Tool tips are added to main buttons to provide hint to user.

### 2.7 Encrypt and Decrypt Flies

All exercise files are saved locally encrypted by lower case of student's name. 

If a student changes his name, all exercise files will be wipe clean.