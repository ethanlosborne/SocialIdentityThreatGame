//Link external functions here.
EXTERNAL set_name(name) //string. displays the speaker's name.
EXTERNAL set_background(bgIndex) //int. changes the bg image and uses a fade.
EXTERNAL set_portrait_slot(whichSlot) //int. -1 to hide, 0-5 to show different characters.
EXTERNAL play_video() //plays the video.
EXTERNAL play_music(whichTrack) //int. plays a looping track from soundManager's music array.
EXTERNAL play_sound(whichTrack) //int. plays a sound track once from soundManager's sound array.
EXTERNAL stop_music() //stops music.
EXTERNAL record_surveys_watched(which)
EXTERNAL show_name_college() //displays the two input fields for the player to enter name and college into.
EXTERNAL show_response_field() //displays the a general purpose input field for the player.
//End external functions.
//character limit: 658.

//display with: {name}
VAR name = "default name"
VAR college = "default college"

-> invitation

=== invitation ===

~set_name("")
Hello. Before we continue, Please take a moment to enter your name and college.
~show_name_college()
...
//OK. Nice to meet you {name} from {college}.
//Now, here's a general question about something. Please do answer.
//~show_response_field()
//...
//Thank you for answering.

~set_background(1)

Hello {name}! We are delighted to announce after reviewing hundreds of applications, you’ve been selected to interview for a summer internship with V Inc. In the next day or so, one of our HR representatives will be calling you to schedule an interview date.
In the meantime, we would like to encourage you to learn a little more about our company by watching the informational video below. This video provides an overview about our summer internship program, and the company as a whole.
Thank you and we look forward to meeting you very soon!

*   [Watch the video] \[I started watching the video.\]

    // plays the video. Progress will be blocked while the video plays.
    //~play_video() //It works, but the video clip is very long (~40 seconds.) I'll disable it for now.
    //Also, it covers multiple lines of dialog in the single clip, but it would be better split in the way
    //that the lines are broken here in the script.

    ~play_music(2)
    ~set_name("Emily Jacobs")
    Hello, I’m Emily Jacobs, Director of the Summer Internship Program at V-Inc. First, I’d like to say congratulations on making it this far in the interview process. This makes you just one of 50 applicants to make it through our highly rigorous and selective process!
I want to welcome you to a brief introduction to our company, V-Inc.

    V-Inc was first established in 1999 as an I.T. training company. It eventually evolved to software development with a focus on customized software, which yielded phenomenal success.
Today V-Inc is a 800 Billion dollar global corporation with an unrivaled portfolio of end to end cutting edge solutions and services from software product development, to block-chain technologies and other smart contract related products.
Ushering businesses into a new era of technology is what we do best at V-Inc. This is our mission.

    At V Inc we have the ability to make more of an impact on people and more of a change in one year than many people do in their lifetimes.
The technology landscape is ever-changing. Six months can be the difference between obsolete and ingenious, so we constantly source the most brilliant, creative and talented young minds to join the team here at V-Inc.
It's how we maintain our lead as innovators in the industry.
    The summer internship program is one of, if not the most critical pipeline Axis Technologies uses to scout and train and recruit exceptional talent that we are confident will propel our company to the future. We typically graduate interns identified as exceptional into permanent positions within the company.
    ~stop_music()
    ~set_name("")
    * * (testimonials)[Watch testimonials from previous interns] \[I'm now watching testimonials from interns.\]

        * * * Jake Maxwell (White guy \#1, block chain data engineering intern)
            ~set_portrait_slot(6)
            ~set_name("Jake Maxwell")
            ~record_surveys_watched(0)
            My name is Jake Maxwell, I’m a graduate intern here at V Inc. Just the process of coding is actually fun.
It’s exciting to work here because unlike a lot of other tech companies, V Inc is on the cutting edge of developing block chain technologies, which is revolutionizing the way smart contracts are executed.
Block chain is the future and V-Inc is literally the rocket that’s taking us there.
            ~set_portrait_slot(-1)
            ~set_name("")
            -> testimonials

        * * * Paola Ortiz (Hispanic girl with accent, marketing intern)
            ~set_portrait_slot(4)
            ~set_name("Paola Ortiz")
            ~record_surveys_watched(1)
            My name is Paola Ortiz and I'm a junior at the University of Denver and I study Marketing and Communications. When I was young, I just looooved the jingles to commercials; I used to memorize TV commercials and act them out.
It always fascinated me how one could see the beauty in everyday things, and make others see that same beauty by playing with words.
            The marketing team that I work with is amazing and I’ve learned more here in 2 months than I ever did as an entry level employee during my gap year at a different company.
            ~set_name("")
            ~set_portrait_slot(-1)
            -> testimonials

        * * * Connor McDermott (White guy \#2, financial analyst intern)
            ~set_portrait_slot(7)
            ~set_name("Connor McDermott")
            ~record_surveys_watched(2)
            I’m Connor McDermott. I study Financial Mathematics at the Massachusetts Institute of Technology. I’m stationed within the finance division in the company and I must admit that I am having the time of my life learning about equity options and pricing V Inc stock for the financial markets.
            Mathematics is beautiful. She is everywhere and in everything- take the Fibonacci sequence in nature, for example! I think if mathematics was a person I’d marry her! Getting up everyday to do what I love, with a super talented team at V-Inc is beyond the dream.
Life couldn’t get any better for me.
            ~set_name("")
            ~set_portrait_slot(-1)
            -> testimonials

        * * * Zhang Wei (Asian girl, software engineering intern)
            ~set_portrait_slot(0)
            ~set_name("Zhang Wei")
            ~record_surveys_watched(3)
            My name is Zhang Wei. I’m from New Haven, Connecticut, where I’m studying physics and computer science at Yale University. I’m an intern in the software engineering department here, where I’ve had the opportunity to work with so many leaders in the field.
            The mentorship has been nothing short of amazing; My coding skills have gone through the roof in such a short time and I’m currently working on writing my own code for a software program to improve technical interviewing for software engineers in the tech industry.
This is my greatest accomplishment yet and I’m excited to be part of the team.
            ~set_name("")
            ~set_portrait_slot(-1)
            -> testimonials

        * * * Logan Stiles (White guy \#3)
            //~ set_portrait_slot(5)
            ~ set_name("Logan Stiles")
            ~ record_surveys_watched(4)
            Hi. I’m Logan Stiles, from Virginia. I’m a graduated intern in the Cyber security division at V Inc, now working full time here as a security analyst, where I work on several cyber-security measures.
I love to code- always have, always will. I’ve been coding since I was 9 years old. My first experience coding for an organization was at age 16 for The National Security Agency.
I got to do some pretty cool stuff that set me on the path to coding for life but working here feels like home and I wouldn’t have it any other way.
            ~set_name("")
            //~ set_portrait_slot(-1)
            -> testimonials

        * * * [Stop watching testimonials] \[I stopped watching testimonials.\]
            -> interviewStart

    * * (interviewStart) [Continue with the interview] \[I decided to continue with the interview.\]
        -> enter_building_reception
- -> enter_building_reception

=== enter_building_reception ===

~set_background(2)
~set_name("")

You have arrived at V-Inc's company campus for your interview. It's 2:30 in the afternoon.

//~show security desk and guards (men. one black, another hispanic)
~set_portrait_slot(1)
~set_name("Security Guard")
OK, Miss {name}, you're good to go. You'll want to head on up to the 10th floor, main reception area—right across from the elevators.

~set_background(3)

//the episode with the cleaning lady.
~set_portrait_slot(8)
~set_name("Cleaning Lady")
Hello.

~set_background(4)
~set_portrait_slot(2)
~set_name("Receptionist")
Good afternoon and welcome to Division D. How may I help you?

//the player must state in her own words that she is here for the interview.
//there are not enough contextual clues to let the player know what they should say: I should tell her I'm here for the interview.
~set_name("")
~show_response_field()
...


~set_name("Receptionist")
The interviews for the administrative assistant interviews position were done an hour ago. And that would have been down the hall, Room 1015. Sorry.

//I need to clarify that I'm here for the internship interview. //there are not enough contextual clues to let the player know what they should say.
~set_name("")
~show_response_field()
...


~set_name("Receptionist")
OHHH! I’m so sorry… We’re hosting 2 interviews today and one just wrapped up. What’s your name, sweetie?

~set_name("{name}")
It's {name}.

~set_name("Receptionist")
Wow! Engineering huh? You must be a chop - you know? Genius! Over 1000 applications each year for those positions and only about 10 make the final cut.

~set_name("")
The receptionist prints out a paper with a number on it and passes it to you.

~set_name("Receptionist")
OK. Your ticket number is D035. Go to the waiting area, room 1016-down the hall to your right-first door-- and wait for your number to be called over the intercom.
The interview room will be RM 1018 directly opposite the waiting area. Shouldn’t be a long wait. Good luck.

~set_name("")
~show_response_field()
... //there are not enough contextual clues to let the player know what they should say.


-> manipulating_social_interactions_waiting_room

=== manipulating_social_interactions_waiting_room ===

~set_portrait_slot(-1) //there is no portrait for Lee
~set_background(6)
~set_background(11) //add all the white engineer background characters. For some reason the asset is apart from the chairs.

//X sits on the only available seat- next to an Asian man who begins to make small talk.
There's only one seat left, so you sit down there.

~set_name("Asian Guy")
You’re here for the internship interview?

~set_name("")
~show_response_field()
...



~set_name("Asian Guy")
My name is Li Wang. You?

~set_name("{name}")
{name}.

~set_name("Li")
Cool. What college?

~set_name("{name}")
{college}.

~set_name("Li")
Sweet. Junior, M.I.T.

~set_name("")
He says, pointing at himself.

~set_name("Li")
It's a little packed but they call people in quickly. It shouldn’t be too long now. Gets nerve-wracking just waiting in a room full of like… super smart people.
See that guy over there with the red shirt? Also from M.I.T. His dad works for Google. I’ll bet you he has an ‘in’ already. And the chick in the blue suit?— total badass. Like… genius level smart! Seriously. Rumor has it that the big companies are already scouting her for jobs after graduation.

~set_name("")
~show_response_field()
...


~set_name("Li")
I hear they hire mostly— well, last year at least—and the year before that— mostly M.I.T and Stanford grads. Like, most of the senior execs in this division graduated from either M.I.T, Yale, Harvard, Stanford or UCLA.

~set_name("")
The intercom buzzes and calls out a number: D-031.

~set_name("Li")
That’s me! Gotta go! Good luck.

~set_portrait_slot(2)
~set_name("")
You notice the receptionist from earlier has come to find you.

~set_name("Receptionist")
{name}? I'm sorry I forgot to give you these ... Can you complete these forms as soon as you can please?

//X receives a link to a survey she should complete [survey is 2 minutes or less--]
//there is no information about the forms? I can implement them, but what should the questions be? Or is this the Working memory challenge? (I don't think so)

~set_portrait_slot(-1)
~set_name("")
Finally, the intercom buzzes again and D-035 is called— it's your turn.

-> manipulating_social_interactions_interview_room

=== manipulating_social_interactions_interview_room ===
//interviewer names:
//#1: Steve
//#2: Sebastian
//#3: Luke
//#4: James
//#5: Mark

~set_background(9)
//X walks across the hall to Rm 1018. On the walls are photos of executives… All White men.
You walk to room 1018.

~set_background(10)
//She opens the door and sees a panel of 4 interviewers sitting at a long table. 3 lean towards each other, whispering to each other. One is writing something in a folder.

~set_name("Luke")
We’re out of coffee. What’s the status on the purchase order Lynette made last week? We’re supposed to restock when inventory hits 25%. Could you follow up on that please? I hate to micromanage but this is really, REALLY getting old!

~set_name("")
He walks to sit in the empty chair at the panel.

//Interviewer \#3 points out that \#5 could be wrong about X:
~set_name("Luke")
Er… wrong person, Mark. She’s not admin, she’s here for the interview. Right? Miss… {name}? D-035?

~set_name("")
~show_response_field()
...


~set_name("Mark")
Oh! Ok- have a seat Miss {name} and let’s get started.

~set_name("")
You sit opposite the panel.

~set_name("Steve")
Hello, {name}. Welcome to V, Inc. My name is Steve- this is Sebastian, Luke, James and Mark.
~set_name("Steve")
We all are senior personnel in Division D- which is also one of the most crucial arms of the company. As a single division, we account for over 42% of the company’s annual revenue.
As you know, our company is rated among top \#3 in the industry. Our success is mostly a result of our innovation in the field. We develop cutting edge products and the rest of the industry –and the market as well-- looks to us to determine the direction of the future, right?
But here’s the thing—the secret to our success lies in being able to tap talent, fresh talent.
So we are constantly looking to push the envelope ourselves, in terms of what it means to be innovative and dominant in the field. So we look for and hire young people like yourself, who are not only talented, but also can bring to the table fresh, creative ideas.
Typically, the internship is a bridge to becoming an employee within the organization. We invest heavily in our interns because we don’t just see them as gophers—but as valuable, future employees.

~set_name("Sebastian")
yes and to what \#1 just said—because we are investing in you, we have very high standards and expectations around work quality and productivity.
But I’ll say, should you be hired, you’ll have it made-even if you don’t end up with a position here.

~set_name("Mark")
And that’s what makes these internships so competitive. Having done an internship at V Inc is very attractive to a lot of companies out there—although to be honest, we tend to keep our interns- so the vetting process- of which this interview is a part—is very rigorous.
We choose the best of the best. We receive about 1200 applications a year; interview about 50 candidates and only hire 12- a whopping 1%. So—you should consider it a success that you’ve made it this far.

~set_name("James")
Alright, enough about us and the company. Tell us a little about yourself. I can see you’re a junior at {college}.

~set_name("")
You can't help but notice two of the interviewers exchange a look at that.

~set_name("")
~show_response_field()
...


~set_name("Steve")
What are your skills and how do you think they can contribute to our division goals?

~set_name("")
~show_response_field()
...


~set_name("Sebastian")
What are you hoping to learn from us this summer?

~set_name("")
~show_response_field()
...


~set_name("Luke")
What’s your communication style? I ask because most of the senior employees that you will be interfacing with in Division D are men – and we generally tend to be straight shooters who do not mince words and tell it like it is.
I know some women might find that offensive so… I guess I’m wondering how comfortable you would feel about that level of communication.

~set_name("")
~show_response_field()
...


-> manipulating_TASK_Gender_social_identity_threat

=== manipulating_TASK_Gender_social_identity_threat ===

~set_name("Mark")
Alright! Thank you, {name}! It was very nice to meet you. We've enjoyed getting to know more about you and your technical skillset. Now, we're gonna switch gears a little bit and do something else.

As part of this interview, we will evaluate your problem-solving skills using a short problem-solving task.
This task is very accurate and predictive of high-level problem-solving skills; typically people who do well on this task excel on the quantitative aspects of the job—which is critical for us.
For that reason, scores on this task are usually weighted more than most other components of the interview; What is it, Steve? I think—50% of our decision to hire will be based on your performance on this task is that right?

~set_name("")
Steve nods in agreement.

~set_name("Mark")
We will have a scoreboard up for you showing the performance of candidates who scored in the top 5%. Last year we had some of the highest, if not the highest, most competitive performers.
Everyone interviewing this year—including you-- will have their performance rated or compared against these guys on the scoreboard…
Ideally we’d be looking to hire those with scores comparable to or higher than last year’s top scores— although higher might be quite hard to beat.

//Show scoreboard—with 5 people and their percentile ranking (1-5%) also include a bogus score. The 5 people are 3 White men and 2 Asian men. Give them super White and Asian names e.g. Wyatt, Cheng, etc.

//X starts task.
//After completing task- X is asked a few questions in a survey (up to 5- I will supply these) about interest in working for the company, stereotype endorsement, etc.

-> END
//Here, the script ends and the WM task starts. After finishing that, the game ends.
