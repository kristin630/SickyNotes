# Smart Sticky Notes

**INTRODUCTION:**<br />
Smart Sticky Notes is a web application that provides users with informative results based on their task-related search queries. It combines a simple, user-friendly interface with a custom search engine in the background and mapping functionality.

It was created with disorganized users in mind, particularly ones who want to get more organized. The user can simply type a query into the field on the screen and see customized results and suggestions on the sticky notes. If the user desires, they can input a query into the map on our web application to help them plan out a task or find the closest location to help them complete the task quickly.

This hybrid between a smart search engine and map interface is designed to help users become less intimidated by tasks. It is easy to get overwhelmed by a long list of things to do, especially when it is difficult to figure out where to begin. Smart Sticky Notes was designed to alleviate some of the stress and struggle related to completing tasks.

**BACKGROUND:**<br />
We were interested in working on a web application that would help disorganized users; in particular, those that might be unsure of where to start with a task. Being able to write down a thought or something on a to-do list and be given informative suggestions based on the text entered would help a disorganized user be more organized.

In addition, being able to search a map within our application is unique to our project. Having the capability to search queries around locations will allow the user to plan out tasks by finding the nearest location related to a task.

To our knowledge, no one else has done a project like this. There are various sticky note applications available, like on the dashboards in Windows and Macintosh operating systems, but none appear to provide smart capabilities.

**METHODOLOGY:**<br />
To develop our web application, we used various technologies. We used Microsoft Visual Studio to write all of our code. Within Visual Studio, we worked with ASP.NET MVC framework to tie together most of the functionality. We coded the back end of the application, namely the Model and Controller, using C# and the front end (View) using HTML, CSS, and JavaScript. In addition, we implemented two of Google’s APIs, Custom Search and Maps. 

The Custom Search API is at the heart of our application, as that API drives the search engine that determines the best results for every entry submitted by the user. The search engine consists of “annotations” and “context”. Annotations specify the type and range of searchable web content— it can either search the full extent of the web, or only search particular websites. Context specifies the fine details of the custom search engine in an XML file. Additional configuration can include custom ranking, refined searches, rewritten queries, filtered search results, and modified result snippets. The Google Maps API is used to allow the user to search a query on a map within our application.

**RESULTS:**<br />
We were able to create a user-friendly interface resembling sticky notes to give the user an idea of where to begin with their task. Users type in their search query into the “Things to do” search box. Upon submission, the Google Custom Search API is invoked, passing in a request string to the search engine that we created and customized. The search engine then returns a list of results to the program, and the top results (maximum of 8) are displayed on the sticky notes.

Using Google Maps API, we were able to allow the user to search the area for a query, typically corresponding to their task, in order to help the user plan out their to-do list. This feature is optional and not tied into the Custom Search portion of the application, allowing the user to only utilize the map as needed.

**CONCLUSION:**<br />
We were able to successfully create a web application that enables a user to organize their thoughts and help them get started on their to-do list. The app creates a list of suggestions based on the user input and gives that user the option to then search keywords having to do with their tasks on Google Maps within our web application. In the future, we would like to give users the option to save their queries and subsequent results to a database, where they can retrieve information at a later time. If Smart Sticky Notes were to eventually be publicly hosted, we would like to use the Google Analytics service, which works well in conjunction with the Custom Search API, to track search engine activity and better understand our users and what they are trying to achieve through our application. From there, we would build on our application, with our goal being making our Smart Sticky Notes application “smarter.”
