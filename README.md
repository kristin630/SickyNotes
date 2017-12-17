# StickyNotes

INTRODUCTION
Smart Sticky Notes is a web application that provides users with informative results based on their task-related search queries. It combines a simple, user-friendly interface with a custom search engine in the background and mapping functionality.

It was created with disorganized users in mind, particularly ones who want to get more organized. The user can simply type a query into the field on the screen and see customized results and suggestions on the sticky notes. If the user desires, they can input a query into the map on our web application to help them plan out a task or find the closest location to help them complete the task quickly.

BACKGROUND
We were interested in working on a web application that would help disorganized users; in particular, those that might be unsure of where to start with a task. Being able to write down a thought or something on a to-do list and be given informative suggestions based on the text entered would help a disorganized user be more organized.

To our knowledge, no one else has done a project like this. There are various sticky note applications available, like on the dashboards in Windows and Macintosh operating systems, but none appear to provide smart capabilities.

METHODOLOGY
To develop our web application, we used various technologies. We worked on Microsoft Visual Studio to write all of our code. Within Visual Studio, we worked with ASP.NET MVC framework to tie together most of the functionality. We coded the back end of the application, namely the Model and Controller, using C# and the front end (View) using HTML, CSS, and JavaScript. In addition, we implemented two of Google’s APIs, Custom Search and Maps. The Custom Search API is at the heart of our application, as that API drives the search engine that determines the best results for every entry submitted by the user. The search engine can either search the full extent of the web, or only search particular websites. Additional configuration can include custom ranking, refined searches, rewritten queries, filtered search results, and modified result snippets. The Google Maps API is used to allow the user to search a query on a map within our application.
