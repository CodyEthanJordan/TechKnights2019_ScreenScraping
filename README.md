# Cheating at Cults and Chimeras: Scraping Screen Data with Python

This is a repository for all of the resources for a workshop for UCF's TechKnights, talking about how to create Python programs which can read data from the screen and use mouse events to interact with other programs. In order to participate I would reccomend installing

##### Software Used
- Download "Cults and Chimeras," a small game I made which we are going to cheat at. This repo has the Unity project if you want to look at it or build it yourself, otherwise I have pre-built executables which you can download and unzip
    - for [Windows](https://drive.google.com/open?id=1SoFuEkeKwzNMsw0JEi8hfl4YmiHZen81)
    - for [Linux](https://drive.google.com/open?id=1oaVliEpLFPN-MKcb73NXE8UoY9p7xAFt)
    - for Mac (coming soon)
- Be able to run Python 3 programs
    - I am using Jupyter Notebooks, with the pyautogui, numpy, matplotlib, and PIL libraries
    - to get this I'd reccomend [downloading Anaconda](https://www.anaconda.com/distribution/) and then using conda to install these
- pyautogui specifically
    - allows easy interaction with the screen and mouse
    - be sure to check the [dependencies](https://pyautogui.readthedocs.io/en/latest/introduction.html#dependencies) if you are using Mac or Linux

##### Goals

Ideally this workshop should introduce the idea of using screen data to control a program, and break down some general "hacking skills" in terms of structuring a program. What I'd like is for everyone to
- Use screen data to control program flow
- Interact with other programs using mouse and keyboard events
- Plan out an incremental attack on a hacking project

##### Outline

In general here is what we are going to do
- clone this repo
- download Cults and Chimeras
    - look over the game, dissect the problem
        - how can we interact with this program?
        - what are we trying to optimize? how well will this work?
- use pyautogui to find and click on buttons
    - [finding buttons](https://pyautogui.readthedocs.io/en/latest/screenshot.html#the-locate-functions)
- get our program to understand what stats we have currently
    - find the numbers on the screen
    - create a corpus of all possible values
    - be able to identify where all 6 numbers are
    - turn that image data in to an integer
- automate rolling

## Links
- [Presentation slides](https://docs.google.com/presentation/d/15XifeJyLFStVtGvmWxyUkEK6Gd0DIzmATkTRIGPFYwI/edit?usp=sharing)
- [This repo](https://github.com/CodyEthanJordan/TechKnights2019_ScreenScraping)
