MIRA: VIRTUAL SHOPPING APPLICATION
_____________
Introduction:
_____________

Our project is a metaverse app developed using the Unity game engine, designed to revolutionize the shopping experience by offering real-time immersive interactions. We understand that scrolling through traditional shopping apps can be monotonous and detached from the excitement of physical shopping. Our application aims to bridge this gap by providing users with a dynamic and engaging virtual reality (VR) environment where they can explore and shop in real-time.

The core feature of our app is the ability for users to create their own avatars, which serves as their virtual representation in the metaverse. This avatar customization empowers users to express their unique style and personality. Once their avatar is created, users can choose from a variety of virtual stores within the metaverse, allowing them to shop at their preferred locations and browse through a wide range of products.

What sets our app apart is the seamless integration of real-time communication. If multiple users wish to shop together in the same virtual store, they can join using their own avatars and experience the shopping adventure together. They can interact with each other, see each other's avatars, and communicate in real-time, enhancing the social aspect of shopping. This not only brings the excitement of shared experiences but also enables users to seek opinions, share recommendations, and have a sense of community while shopping virtually.

By leveraging the power of VR, our application provides users with a heightened sense of presence and immersion. They can explore the virtual stores, examine products up close, and even try them on using virtual fitting rooms. The realistic graphics and rendering ensure that users get a vivid and detailed representation of the products, replicating the feeling of being physically present in the store.

Additionally, our app incorporates user-friendly interfaces and intuitive controls, ensuring a seamless and enjoyable shopping experience. We have utilized technologies such as WebGL: JavaScript API, Photon Unity Networking (PUN), Newtonsoft.Json, and the Wolf3D ReadyPlayerMe Unity SDK to create a robust and efficient system for networking, real-time communication, and avatar customization.

Overall, our metaverse app aims to redefine the way people shop online, providing an exciting and interactive alternative to traditional shopping apps. By combining the power of virtual reality, real-time communication, and avatar customization, we offer users a dynamic platform to experience live shopping and connect with others in an engaging and immersive manner.

___________________
Problem Statement:
___________________

The problem we aimed to address with our metaverse app is the lack of real-time and immersive experiences in traditional shopping applications. Many users find the process of scrolling through mundane shopping apps to be monotonous and disconnected from the excitement and interactivity of physical shopping. Additionally, there is a desire for social engagement and shared experiences while shopping online, which is often lacking in conventional platforms.

Our goal was to create a solution that enables users to have a real-time shopping experience, where they can explore virtual stores, interact with products, and connect with others in a dynamic and immersive manner. We recognized the need for a more engaging and interactive platform that would allow users to feel a sense of presence and community while shopping online.

By developing our metaverse app using the Unity game engine and integrating virtual reality (VR) development, we aimed to bring users closer to the excitement and liveliness of physical shopping. The ability for users to create their own avatars and choose the store they wish to connect with adds a personal touch to their shopping experience, allowing them to express their unique style and preferences.

Furthermore, our app addresses the desire for social interactions by enabling multiple users to join the same virtual store simultaneously. Through the application, users can create their avatars, see each other in real-time, and communicate with one another. This not only fosters a sense of community but also allows for shared experiences, recommendations, and opinions while shopping virtually.

To ensure a seamless and immersive experience, we utilized graphics and rendering techniques to create realistic representations of products within the virtual stores. Additionally, we incorporated networking and real-time communication technologies such as Photon Unity Networking (PUN) and the Wolf3D ReadyPlayerMe Unity SDK to enable smooth interactions and synchronization between users.

In summary, the problem we aimed to solve was the lack of real-time and immersive shopping experiences in traditional apps. Our metaverse app tackles this problem by providing users with the ability to shop in real-time, create personalized avatars, connect with others, and enjoy an engaging and interactive shopping experience.

_______________
Key Features:
________________

Avatar Creation: Our application allows users to create their own unique avatars, customizing their appearance to reflect their personal style. From choosing facial features to selecting clothing and accessories, users can express themselves and create an avatar that represents their virtual shopping identity.


Virtual Store Selection: Users have the freedom to choose from a wide range of virtual stores within our application. Whether it's a boutique fashion store, a tech gadget shop, or a bustling marketplace, users can explore and shop from various virtual environments tailored to their interests.


Real-Time Interaction: One of the standout features of our application is the ability for users to interact with other shoppers in real time. Users can see and communicate with each other through their avatars, creating a social and collaborative shopping experience. Share recommendations, exchange fashion tips, or simply enjoy shopping together in a dynamic and interactive virtual environment.


Immersive Shopping Experience: With realistic graphics and detailed store designs, our application provides an immersive shopping experience that goes beyond conventional shopping apps. Users can virtually walk through aisles, examine products up close, and even try them on virtually to get a true sense of their potential purchase.


Seamless Purchase Process: Our application streamlines the purchasing process, allowing users to add items to their virtual cart, review product details, and make secure purchases within the virtual environment. Users can complete transactions seamlessly without being redirected to external websites or apps.



___________________________________
Design, Implementation, and Usage:
Design and Implementation:
___________________________________

MIRA is built on a robust design architecture, utilizing various technologies and frameworks to deliver a seamless and immersive virtual shopping experience. In this section, we will provide an overview of the design and technical implementation of the application.

____________________
Design Architecture:
____________________

The design architecture of MIRA follows a client-server model, allowing users to connect to the application and interact within the virtual environment. Here is a high-level overview of the key components:


>>>>>>>>> Client-Side:


User Interface: The client-side of the application is responsible for rendering the virtual environment, user avatars, store layouts, and product displays. It provides an intuitive user interface that allows users to navigate, interact, and shop within the virtual world.
Avatar System: The avatar system enables users to create and customize their unique avatars, incorporating various design elements such as facial features, hairstyles, clothing, and accessories.
User Interaction: The client-side handles user input, allowing users to move, interact with objects, browse products, and communicate with other users in real time.

>>>>>>>>> Server-Side:

Store Management: The server-side manages the virtual stores available in the application, including their layouts, product inventories, and real-time synchronization between multiple users.
User Management: The server-side handles user authentication, avatar customization data, and user interactions within the virtual environment, facilitating real-time communication and collaboration among users.
Technologies and Frameworks:
MIRA leverages the following technologies, frameworks, and design patterns to implement its functionality:


Unity 3D: The application is developed using Unity 3D, a powerful game development engine that provides extensive tools and features for building immersive virtual reality experiences.


Virtual Reality SDKs: [Specify the VR SDKs you have used, such as Oculus SDK, SteamVR, or Windows Mixed Reality], which enable seamless integration with different VR hardware devices and provide access to essential VR functionalities.


Networking: To enable real-time interactions and synchronization between multiple users, the application utilizes networking protocols and libraries to establish connections, exchange data, and maintain the integrity of the virtual environment.


Object Interaction: The application employs object interaction techniques, including raycasting and collision detection, to enable users to interact with virtual objects, pick up items, and trigger actions within the virtual stores.


User Interface Design: The application follows best practices in user interface design to provide an intuitive and immersive shopping experience. It incorporates visual cues, icons, and navigation controls that are optimized for VR environments.

___________
Algorithms:
___________

While MIRA focuses primarily on providing an immersive shopping experience, there are underlying algorithms that contribute to its functionality. These include:


Collision Detection: The application implements collision detection algorithms to ensure that avatars and virtual objects interact realistically, preventing unintended overlapping or clipping.


Pathfinding: If applicable, the application may utilize pathfinding algorithms to guide avatars through complex store layouts, ensuring efficient navigation and avoiding obstacles.


Rendering Optimization: To provide a smooth and immersive experience, rendering optimization techniques, such as level-of-detail (LOD) rendering or occlusion culling, may be implemented to optimize the performance of the application and maintain a consistent frame rate.


Overall, the design and implementation of MIRA are aimed at delivering a captivating and interactive virtual shopping experience. Through the utilization of cutting-edge technologies, frameworks, and design patterns, we have strived to create a seamless and immersive environment that blurs the line between virtual and physical retail experiences.



The core technology used in our project is Unity, which provides a powerful game engine and development environment for creating immersive virtual reality (VR) applications. Unity allows us to design and implement the interactive elements of the metaverse app, including avatar customization, store selection, and real-time communication.

                                                                                 ___________________________________________
To facilitate networking and real-time communication between users, we integrated ______Photon Unity Networking (PUN)_______. PUN provides a framework for multiplayer functionality, enabling multiple users to join the same virtual store, interact with each other, and see each other's avatars in real-time. This dependency allows for a seamless and synchronized experience for all participants.
If we want to create a clean import of PUN, we can skip the Demos folders, and optionally use the UtilityScripts folder for rapid prototyping. PUN supports C# programming language, but it does not support UnityScript (JavaScript) with PUN v2 and up.
To use Photon Cloud, you can subscribe to the service through the PUN Wizard Editor window. The Photon Cloud is a managed server geared towards room-based games, and the server cannot be modified. Alternatively, you can download the Server SDK and run your own Photon Server, which includes source code and projects for the game logic.



                                                        ______________________________
For avatar creation and customization, we leveraged the _Wolf3D ReadyPlayerMe Unity SDK_. This SDK integrates with the www.readyplayer.me avatar platform, enabling users to load and display avatars created on the website. By using this dependency, users can personalize their avatars and have a unique representation within the metaverse.


In terms of graphics and rendering, our project utilizes Unity's built-in capabilities. We take advantage of Unity's rendering pipeline and shaders to create realistic representations of products and environments within the virtual stores. This ensures that users have visually appealing and immersive shopping experiences.


The user interface (UI) design is an essential aspect of our project. We have implemented intuitive UI elements to facilitate avatar creation, store selection, and interaction with products. By considering user experience and usability principles, we aim to provide a seamless and enjoyable shopping journey.



The project's usage involves users downloading and installing the application on their devices, which should support VR capabilities. Once the app is launched, users can create their avatars, choose a virtual store, and start their live shopping experience. They can explore the store, interact with products, and communicate with other users who have joined the same store in real-time.

             _____________
The required dependencies for our project include the following:
- Newtonsoft.Json: This library is used for JSON serialization and deserialization, enabling efficient data exchange and communication between different components of the app.
- Siccity.GLTFUtility: This dependency allows for the loading and display of glTF models, enhancing the visual fidelity of the virtual stores by importing realistic 3D models.
- Photon3Unity3D: This library provides the networking and real-time communication functionality through the integration with Photon Unity Networking (PUN).
- Wolf3D ReadyPlayerMe Unity SDK: This SDK is utilized for avatar loading and display, allowing users to personalize their avatars based on the readyplayer.me platform.
-Photon Realtime C# Client: Photon Realtime C# Client library by importing the necessary files and scripts into your Unity project. We would typically use this library in combination with the Photon Unity Networking (PUN) package mentioned earlier to create multiplayer functionality in our game.



To successfully install and run your metaverse app developed in Unity, you need to ensure that the following dependencies, prerequisites, and configuration steps are met:


Unity Game Engine: Download and install the Unity Game Engine from the official Unity website (https://unity.com). Make sure to choose the appropriate version compatible with your operating system.


Virtual Reality (VR) Development: Set up your VR hardware and software. Ensure that you have a compatible VR headset and that the necessary drivers and software are installed.


Graphics and Rendering: Verify that your computer meets the minimum system requirements for graphics and rendering capabilities. Update your graphics drivers to the latest version to ensure optimal performance.


Networking and Real-Time Communication: Install Photon Unity Networking (PUN), a Unity package that provides networking functionality for real-time communication between users. You can download PUN from the Unity Asset Store or the Photon website (https://www.photonengine.com). Follow the documentation and import the package into your Unity project.


User Interface (UI) Design: Utilize Unity's built-in UI system to design and create the user interface for your metaverse app. Ensure that you have a good understanding of UI design principles and techniques.

______
WebGL: JavaScript API: If you intend to deploy your app as a WebGL application, you need to have a compatible web browser installed on your computer. Additionally, familiarize yourself with the WebGL JavaScript API, as it is essential for building and running WebGL applications.


Newtonsoft.Json: Incorporate the Newtonsoft.Json library into your Unity project. You can obtain this library from the Unity Asset Store or the official Newtonsoft website (https://www.newtonsoft.com/json). Follow the installation instructions specific to the library to integrate it into your project successfully.


Wolf3D ReadyPlayerMe Unity SDK: Integrate the Wolf3D ReadyPlayerMe Unity SDK into your project. This SDK enables avatar creation and customization. Obtain the SDK from the official Wolf3D ReadyPlayerMe website (https://www.readyplayer.me) and follow the provided instructions to install and set it up within your Unity project.




Once you have set up your development environment and incorporated the required components and libraries, you can build and run the code for your metaverse app. Use Unity's build settings to target your desired platform (such as PC, VR headset, or web browser) and compile the project. Deploy the built application to the appropriate platform and test its functionality.


Ensure that you follow best practices for testing, debugging, and optimizing your code throughout the development process. Regularly test the app's networking capabilities, avatar interactions, and real-time communication to ensure a smooth and immersive shopping experience for users in the metaverse.


Installation Steps:


Clone or download the MIRA repository from the GITHUB to your local machine.


Open Unity and create a new project or open an existing project.


Import the downloaded MIRA project into Unity by selecting "Assets" -> "Import Package" -> "Custom Package" and navigating to the downloaded project folder. Choose the relevant package files and click "Import" to import them into your Unity project.


Set up the project settings according to your preferred platform (Windows, macOS, Linux).


Connect your VR headset and controllers to your computer and ensure they are properly recognized by Unity.


Build and run the project by selecting "File" -> "Build Settings" and choosing your target platform. Click "Build and Run" to compile the project and launch it on your VR headset.


Please note that the specific configuration steps may vary depending on your VR hardware and Unity version. Refer to the documentation provided with your VR headset and Unity documentation for detailed instructions.


Supported Platforms:


[List the supported platforms, e.g., Windows, macOS, Linux]
Congratulations! You have successfully installed MIRA and are ready to explore the world of real-time shopping experiences in a virtual environment. If you encounter any issues during the installation process, please refer to the troubleshooting section in this document or reach out to our support team for assistance.


Happy shopping in the virtual realm!






Future Enhancements:


While MIRA already offers an exciting and immersive real-time shopping experience, there are several potential future enhancements that can further elevate the application and provide even more value to users. Here are some ideas for future improvements:


Expanded Store Selection: Currently, the application offers a selection of virtual stores for users to explore. In the future, we aim to expand the store catalog, partnering with real-world brands and retailers to provide a diverse range of virtual shopping destinations. This would offer users a wider array of products and experiences within the application.


Social Features: Enhancing the social aspect of MIRA can create a more interactive and engaging shopping environment. Introducing features such as chat functionality, friend lists, and virtual gatherings would allow users to connect, interact, and share their shopping experiences with friends and like-minded individuals in real time.


Customizable Virtual Spaces: Providing users with the ability to customize their own virtual spaces, such as personal showrooms or virtual closets, would add a personalized touch to the application. Users could curate and display their favorite products, create wish lists, and showcase their unique style to others.


Enhanced Product Interactions: To further enrich the shopping experience, implementing features such as product demonstrations, 360-degree views, and virtual try-on options would allow users to engage more deeply with products before making a purchase decision. This could include integrating augmented reality (AR) functionalities for virtual fitting rooms or overlaying virtual objects onto the user's real-world environment.


Gamification Elements: Introducing gamification elements can add an element of fun and reward to the shopping experience. Incorporating challenges, achievements, and virtual currency systems would incentivize users to explore the application, participate in events, and unlock exclusive offers or discounts.


Integration with E-commerce Platforms: Enabling seamless integration with e-commerce platforms would allow users to not only browse and experience products in the virtual environment but also make real purchases within the application. This integration would provide a streamlined shopping journey, from virtual exploration to secure online transactions.


Personalization and Recommendations: Implementing personalized recommendations based on user preferences, purchase history, and browsing behavior would enhance the application's usability and provide users with tailored product suggestions. By leveraging machine learning algorithms, MIRA can intelligently adapt to each user's unique tastes and preferences.


Cross-Platform Support: While MIRA currently supports specific platforms (e.g., Windows, macOS, Linux), expanding compatibility to additional platforms, such as mobile devices or standalone VR headsets, would enable a broader user base to access and enjoy the application's features.


These future enhancements demonstrate our vision for MIRA's growth and improvement, aiming to continuously innovate and provide an unparalleled virtual shopping experience. By incorporating user feedback, staying up-to-date with emerging technologies, and forging partnerships with industry leaders, we strive to make MIRA the go-to platform for immersive, real-time shopping experiences.


Please note that the implementation of these future enhancements may depend on various factors, including technological advancements, user demand, and available resources.
Troubleshooting:


While MIRA is designed to provide a seamless and enjoyable shopping experience, users may occasionally encounter issues or errors. This section aims to address common problems and provide possible solutions to help users troubleshoot and resolve any difficulties they may face. Additionally, we will highlight any known limitations or caveats that users should be aware of to ensure a smoother experience.


Performance Issues:


Lag or Frame Drops: If you experience lag or frame drops during gameplay, try lowering the graphics settings within the application. Adjusting options such as resolution, anti-aliasing, or shadow quality can help improve performance on lower-end hardware.
Hardware Compatibility: Ensure that your system meets the minimum requirements for running MIRA. Check for updated graphics drivers and ensure that your system is running the latest software updates for optimal performance.
Avatar and Store Interactions:


Avatar Glitches or Clipping: In rare instances, avatars may experience glitches or clipping issues within the virtual environment. If you encounter such problems, try resetting your avatar's position or reloading the store to resolve the issue.
Unresponsive Objects: If you encounter objects in the store that do not respond to interactions or actions, make sure you are using the correct input method (e.g., keyboard, controller, or VR hand controllers) as specified in the application's documentation. Additionally, ensure that the objects are intended to be interactive within the store.
Network Connectivity:


Connection Issues: If you are unable to connect to the application or experience frequent disconnections, check your internet connection and ensure that it is stable. Try restarting your network devices (modem, router) and reconnecting to the application.
Firewall or Antivirus Interference: In some cases, firewall or antivirus software may block the application's network connection. Ensure that MIRA is added to the exceptions or allowed list in your firewall or antivirus settings.
Known Limitations:


Store Availability: While we strive to provide a wide range of virtual stores within MIRA, there may be limitations in terms of the number and variety of available stores. We are continuously working to expand the store catalog and bring more exciting options to our users.
Product Inventory: The availability of specific products within the virtual stores may vary, as it depends on partnerships and agreements with real-world brands and retailers. Some products may be for demonstration purposes only and not available for purchase within the application.
Platform Compatibility: MIRA currently supports specific platforms (e.g., Windows, macOS, Linux). Ensure that you are using a supported platform to ensure optimal performance and functionality.
If you encounter any other issues or errors not covered in this troubleshooting guide, we encourage you to reach out to our support team or consult our online documentation for further assistance. We are committed to providing timely support and addressing any concerns to ensure a smooth and enjoyable shopping experience for all users.


Please note that troubleshooting steps and solutions may vary depending on individual system configurations and specific circumstances.


CONTACT INFORMATION:
choudhary.21@iitj.ac.in
sorte.1@iitj.ac.in
BTech, 3rd Year
IIT Jodhpur