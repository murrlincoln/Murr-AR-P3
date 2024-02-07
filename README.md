# AR Book Cover Project

This repository contains a Unity project for an augmented reality (AR) book cover using the Vuforia Engine. It is designed to overlay interactive 3D text onto a physical book cover when viewed through a camera using a mobile device.

## Getting Started

These instructions will guide you through setting up the project on your local machine for development and testing purposes.

### Prerequisites

Before you begin, ensure you have the following installed:
- [Unity Hub](https://unity.com/download) with Unity Editor (Version 20XX.X.X or later)
- [Vuforia Engine](https://developer.vuforia.com/) AR package (installable via Unity Package Manager)

### Installation

1. **Clone the Repository**


2. **Open the Project in Unity**

Launch Unity Hub, click on 'Add' and select the cloned project directory to add it to the list of projects. Then, click on the project to open it with the Unity Editor.

3. **Set Up Vuforia**

- Go to `Window > Package Manager` and install the Vuforia Engine AR package.
- Go to `Edit > Project Settings > Vuforia` and enter your Vuforia license key, which can be set up for free on their website.

4. **Load the Scene**

Open the main scene which contains the AR setup by navigating to `Assets > Scenes` and double-clicking on the scene file.

### Configuring Your Book Cover

To use your own book cover as an image target:

1. **Create a Vuforia Database**

- Log in to the Vuforia Developer Portal.
- Go to the `Target Manager` and create a new database.
- Add your book cover image to the database and download the Unity package.

2. **Import the Database**

- In Unity, go to `Assets > Import Package > Custom Package` and import the downloaded database.

3. **Set Up Image Target**

- Select the Image Target in the scene.
- In the Inspector, set the Database and Image Target properties to your imported database and image.

### Testing the Application

To test the AR application:

1. **Connect a Mobile Device**

Connect your iOS or Android device to your computer.

2. **Build and Run**

- Go to `File > Build Settings`, select your platform, and click `Build and Run`. Note that testing was done on a Windows computer using the webcam, so it may not work out of the box on mobile devices.

