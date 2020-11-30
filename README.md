# BayonetTickets

Bayonet Tickets is a small, open sourced IT support ticketing application which has been integrated to be centralized around a [Rocket.Chat](https://rocket.chat) server. 

Users submit tickets through the application, and after setting up bot account for your RC server, it posts to a ticketing group defined.

The [Bayonet Ticket Manager](https://github.com/starhound/Bayonet_Ticket_Manager) then allows members of your IT team to view tickets and mark them as "In Progress" or "Complete", along with the input of notes regarding the solution or work performed.

You will need to supply a Rocket.Chat [bot account information](https://github.com/starhound/BayonetTickets/blob/master/Ticketing_Stub/API.cs#L12), the room ID of your tickets group, along with a [Imgur Client ID and Client Secret](https://github.com/starhound/BayonetTickets/blob/master/Ticketing_Stub/Form1.cs#L37). 

You can find more information about the Imgur API and how to register your application from [here](https://api.imgur.com/).

[!Image of Application](https://i.imgur.com/CqBlK6I.png)
