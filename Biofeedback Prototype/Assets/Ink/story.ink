//Link external functions here.
EXTERNAL set_name(name) //string. displays the speaker's name.
EXTERNAL set_background(bgIndex) //int. changes the bg image and uses a fade.
EXTERNAL set_portrait_slot(whichSlot) //waiting for more info about portraits first.
EXTERNAL play_music(whichTrack) //int. plays a looping track from soundManager's music array.
EXTERNAL play_sound(whichTrack) //int. plays a sound track once from soundManager's sound array.
EXTERNAL stop_music() //stops music.
//End external functions.

//You can call one like so:
//~set_background(0)

-> invitation

// Marj section START
=== invitation ===

/* character limit test:
aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.
(the above line is 658 characters.)
result: 658 characters */

~set_name("")
~set_background(1)
Part I: The Invitation

Hello X! We are delighted to announce after reviewing hundreds of applications, you’ve been selected to interview for a summer internship with V Inc. In the next day or so, one of our HR representatives will be calling you to schedule an interview date.
In the meantime, we would like to encourage you to learn a little more about our company by watching the informational video below. This video provides an overview about our summer internship program, and the company as a whole. Thank you and we look forward to meeting you very soon!

*   [Watch the video] \[I started watching the video.\]
    ~ set_name("Emily Jacobs")
    Hello, I’m Emily Jacobs, Director of the Summer Internship Program at V-Inc. First, I’d like to say congratulations on making it this far in the interview process. This makes you just one of 50 applicants to make it through our highly rigorous and selective process! I want to welcome you to a brief introduction to our company, V-Inc.

    V-Inc was first established in 1999 as an I.T. training company. It eventually evolved to software development with a focus on customized software, which yielded phenomenal success. Today V-Inc is a 800 Billion dollar global corporation with an unrivaled portfolio of end to end cutting edge solutions and services from software product development, to block-chain technologies and other smart contract related products. Ushering businesses into a new era of technology is what we do best at V-Inc. This is our mission.

    At V Inc we have the ability to make more of an impact on people and more of a change in one year than many people do in their lifetimes. The technology landscape is ever-changing. Six months can be the difference between obsolete and ingenious, so we constantly source the most brilliant, creative and talented young minds to join the team here at V-Inc. It's how we to maintain our lead as innovators in the industry.
    The summer internship program is one of, if not the most critical pipeline Axis Technologies uses to scout and train and recruit exceptional talent that we are confident will propel our company to the future. We typically graduate interns identified as exceptional into permanent positions within the company.
    ~set_name("")
    * * (testimonials)[Watch testimonials from previous interns] \[I'm now watching testimonials from interns.\]

        * * * Jake Maxwell (White guy \#1, block chain data engineering intern)
            ~ set_name("Jake Maxwell")
              My name is Jake Maxwell, I’m a graduate intern here at V Inc. Just the process of coding is actually fun. It’s exciting to work here because unlike a lot of other tech companies, V Inc is on the cutting edge of developing block chain technologies, which is revolutionizing the way smart contracts are executed. Block chain is the future and V-Inc is literally the rocket that’s taking us there.
              ~set_name("")
              * * * * [Return to selection screen]
              -> testimonials

        * * * Paola Ortiz (Hispanic girl with accent, marketing intern)
            ~ set_name("Paola Ortiz")
            My name is Paola Ortiz and I'm a junior at the University of Denver and I study Marketing and Communications. When I was young, I just looooved the jingles to commercials; I used to memorize TV commercials and act them out. It always fascinated me how one could see the beauty in every day things, and make others see that same beauty by playing with words.
            The marketing team that I work with is amazing and I’ve learned more here in 2 months than I ever did as an entry level employee during my gap year at a different company.
            ~set_name("")
            * * * * [Return to selection screen]
              -> testimonials

        * * * Connor McDermott (White guy \#2, financial analyst intern)
            ~ set_name("Connor McDermott")
            I’m Connor McDermott. I study Financial Mathematics at the Massachusetts Institute of Technology. I’m stationed within the finance division in the company and I must admit that I am having the time of my life learning about equity options and pricing V Inc stock for the financial markets.
            Mathematics is beautiful. She is everywhere and in everything- take the Fibonacci sequence in nature, for example! I think if mathematics was a person I’d marry her! Getting up everyday to do what I love, with a super talented team at V-Inc is beyond the dream. Life couldn’t get any better for me.
            ~set_name("")
            * * * * [Return to selection screen]
              -> testimonials

        * * * Zhang Wei (Asian girl, software engineering intern)
            ~ set_name("Zhang Wei")
            My name is Zhang Wei. I’m from New Haven, Connecticut, where I’m studying physics and computer science at Yale University. I’m an intern in the software engineering department here, where I’ve had the opportunity to work with so many leaders in the field.
            The mentorship has been nothing short of amazing; My coding skills have gone through the roof in such a short time and I’m currently working on writing my own code for a software program to improve technical interviewing for software engineers in the tech industry. This is my greatest accomplishment yet and I’m excited to be part of the team.
            ~set_name("")
            * * * * [Return to selection screen]
              -> testimonials

        * * * Logan Stiles (White guy \#3)
            ~ set_name("Logan Stiles")
            Hi. I’m Logan Stiles, from Virginia. I’m a graduated intern in the Cyber security division at V Inc, now working full time here as a security analyst, where I work on several cyber-security measures. I love to code- always have, always will. I’ve been coding since I was 9 years old.
            My first experience coding for an organization was at age 16 for The National Security Agency. I got to do some pretty cool stuff that set me on the path to coding for life but working here feels like home and I wouldn’t have it any other way.
            ~set_name("")
            * * * * [Return to selection screen]
              -> testimonials

        * * * [Stop watching testimonials] \[I stopped watching testimonials.\]
            -> interviewStart

    * * (interviewStart) [Continue with the interview] \[I decided to continue with the interview.\]
        \[To be continued...\]


- -> manipulating_social_interactions_waiting_room
// Marj section END

// Mason section START
=== enter_building_reception ===

    //~set_background(2) #TODO. I believe we're still missing this bg image.
    ~set_name("")

    On this day X has been invited to the company’s campus for an interview. Her appointment is set for 2:30pm. She walks into the building and checks in at the security desk; There are two security guards (men) at the front door—one Black, another Hispanic. X checks in at the security desk. She presents her interview card, and states that she is interviewing with Division D.
    Black Guard looks at her interview card and ID, checks her name on an ipad (or computer) and says: “10th Floor, Main reception area- right across the elevators.”

    ~set_background(3)

    X goes through security and is allowed into the foyer. It’s exquisite —well decorated, people in suits (men, mostly) walking about hurriedly, minding their own business. There seems to be a sense of urgency in this work environment.
    * * * [Head to the elevators] \[I walked to the elevators.\]
    X heads to the elevator. A cleaning lady (White woman) walks by with a cleaning cart and says ‘Hello’ to X as she continues on her way.
    * * * * [Press the 10th floor button] \[I pressed the 10th floor button.\]
    X takes the elevator to the 10th floor. Walks straight to the reception area and meets receptionist; a Black woman in her mid-thirties, with a short Afro.

    ~set_background(4)
    ~set_name("Receptionist")
    //~show receptionist
    Receptionist: Good afternoon and welcome to Division D. How may I help you?

    ~set_name("X")
    [ this is free flow and X will have to state in her own words that she is there for the interview].

    ~set_name("Receptionist")
    The interviews for the admininistrative assistant interviews position were done an hour ago. And that would have been down the hall, Room 1015. Sorry.

    ~set_name("X")
    X: [states that she is here for the internship interview]

    ~set_name("Receptionist")
    Receptionist:  OHHH! I’m so sorry…we’re hosting 2 interviews today and one just wrapped up. What’s your name sweetie?

    ~set_name("X")
    [X states her names for the record].

    ~set_name("Receptionist")
    Types into a computer. Makes small talk.
    Wow! Engineering huh? You must be a chop - you know? Genius! Over 1000 applications each year for those positions and only about 10 make the final cut (she smiles at X).

    ~set_name("")
    Receptionist prints out a paper with a number on it.  Gives the paper to X.

    ~set_name("Receptionist")
    OK. Your ticket number is D035. Go to the waiting area, room 1016-down the hall to your right-first door-- and wait for your number to be called over the intercom. The interview room will be RM 1018 directly opposite the waiting area. Shouldn’t be a long wait. Good luck.
    * * * * *  [Respond to the receptionist]
        -> manipulating_social_interactions_waiting_room
    * * * * * [Don't respond to the receptionist]
        -> manipulating_social_interactions_waiting_room
// Mason section END

// Marj section START
=== manipulating_social_interactions_waiting_room ===

~set_background(6)

X gets to Rm 1016. It is quite packed. She looks around. There are about 15 people waiting. Some are busy looking at their phones, others are chatting with each other…and some are reading books or just sitting and staring into space.
There’s only one other woman in the room besides herself. This woman is Asian. Of the 14 men, 8 are white, and 6 are Asian.

* [Find a seat]
X sits on the only available seat- next to an Asian man who begins to make small talk.

~set_name("Asian Guy")
You’re here for the internship interview?

~set_name("X")
//X: “yes/ [or whatever variation of response X gives]”
** "Yes."

~set_name("Asian Guy")
My name is Li Wang. You?

//X: X
*** "X Lastname."

~set_name("Li")
Cool. What college?

~set_name("X")
//X: [whatever college she provides—I think we should provide her a college as part of her character, going in].
**** "I went to \[insert college\]."

~set_name("Li")
Li: Sweet. Junior, M.I.T. (he says, pointing at himself). Looks a little packed but they call people in quickly. I shouldn’t be too long now. Gets nerve-wracking just waiting in a room full of like…super smart people.
See that guy over there with the red shirt? Also from M.I.T. His dad works for google. I’ll bet you he has an ‘in’ already. And the chic in the blue suit? [points to Asian woman]- total badass. Like … genius level smart! Seriously. Rumor has it that the big companies already scouting her for jobs after graduation.

~set_name("X")
//X: [responds however she responds].
***** "\[insert response\]"

~set_name("Li")
I hear they hire mostly- well, last year at least—and the year before that- mostly M.I.T and Stanford grads. Like, most of the senior execs in this division graduated from either M.I.T, Yale, Harvard, Stanford or UCLA.

// Intercom buzzes and calls out a number—D-031.
****** \[The intercom buzzes and calls out a number-D-031.\]

~set_name("Li")
That’s me! Gotta go! Good luck.

~set_background(7)
~set_name("")
Receptionist enters...and goes to X.

~set_name("Receptionist")
X? I'm sorry I forgot to give you these ... can you complete these forms as soon as you can please?

~set_name("")
X receives a link to a survey she should complete [survey is 2 minutes or less--]
After distraction task/ bougus survey (or maybe identity threat inducing one) —intercom buzzes and X’s number is called. D-035.

- * [Head towards interview room] \[I headed towards the interview room.\]
    -> manipulating_social_interactions_interview_room

=== manipulating_social_interactions_interview_room ===

~set_background(9)

X walks across the hall to Rm 1018. On the walls are photos of executives… All White men. She opens the door and sees a panel of 4 interviewers sitting at a long table. 3 lean towards each other, whispering to each other. One is writing something in a folder.

//~set_background(10) #TODO. when we have room 1018/background 10 made.

As she walks into the room, Interviewer \#5 comes in from a side door with a mug in hand. Looks at X and says

~set_name("Interviewer \#5")
We’re out of coffee. What’s the status on the purchase order Lynette made last week? We’re supposed to restock when inventory hits 25%. Could you follow up on that please? I hate to micromanage but this is really REALLY getting old!

~set_name("")
He walks to sit in the empty chair at the panel.

Interviewer \#3 points out that \#5 could be wrong about X: “ Er… wrong person, Stan. She’s not admin, she’s here for the interview. Right? Ms… X? D-035?”

//X: [nods, says yes, whatever—something affirmative].
** "Yes/something affirmative"

~set_name("Interviewer \#5")
Oh! Ok- have a seat Ms. X and let’s get started.

*** [Take a seat]
X sits opposite the panel.

~set_name("Interviewer \#1")
Hello, X. Welcome to V, Inc. My name is A- this is B, C, D and E. We all are senior personnel in Division D- which is also one of the most crucial arms of the company. As a single division, we account for over 42% of the company’s annual revenue.

**** [...]
 As you know, our company is rated among top \#3 in the industry. Our success is mostly a result of our innovation in the field. We develop cutting edge products and the rest of the industry –and the market as well-- looks to us to determine the direction of the future, right?

 But here’s the thing—the secret to our success lies on being able to tap talent, fresh talent. So we are constantly looking to push the envelope ourselves, in terms what it means to be innovative and dominant in the field. So we look for and hire young people like yourself, who are not only talented, but also can bring to the table fresh, creative ideas.

 Typically, the internship is a bridge to becoming an employee within the organization. We invest heavily in our interns because we don’t just see them as gophers—but as valuable, future employees.

***** [...]
~set_name("Interviewer \#2")
yes and to what \#1 just said—because we are investing in you, we have very high standards and expectations around work quality and productivity. But I’ll say, should you be hired, you’ll have it made-even if you don’t end up with a position here.

****** [...]
~set_name("Interviewer \#5")
And that’s what makes these internships so competitive. Having done an internship at V Inc is very attractive to a lot of companies out there—although to be honest, we tend to keep our interns- so the vetting process- of which this interview is a part—is very rigorous.
We choose the best of the best. We receive about 1200 applications a year; interview about 50 candidates and only hire 12- a whopping 1%. So—you should consider it a success that you’ve made it this far.

******* [...]
~set_name("Interviewer \#4")
Alright, enough about us and the company. Tell us a little about yourself. I can see you’re a junior at [insert X’s college—definitely not the high end ones they come from].

As \#4 mentions the college, 2 interviewers look at each other and then look down.

~set_name("X")
[states her college].

~set_name("Interviewer \#1")
What are your skills and how do you think they can contribute to our division goals?

~set_name("X")
Responds [we should capture their responses potentially for analyses later]

//X: -------
******** \[insert response 1\]
******** \[insert response 2\]

~set_name("Interviewer \#2")
What are you hoping to learn from us this summer?

//X: -----------
******** \[insert response 1\]
******** \[insert response 2\]

~set_name("Interviewer \#3")
- - - What’s your communication style? I ask because most of the senior employees that you will be interfacing with in Division D are men – and we generally tend to be straight shooters who do not mince words & tell it like it is.
I know some women might find that offensive so…. I guess I’m wondering how comfortable you would feel about that level of communication.

//X: -------
******** \[insert response 1\]
            -> manipulating_TASK_Gender_social_identity_threat
******** \[insert response 2\]
            -> manipulating_TASK_Gender_social_identity_threat

// Marj section END



// Aaja section
=== manipulating_TASK_Gender_social_identity_threat ===

~set_name("Interviewer \#5")
Alright! Thank you, X! It was very nice to meet you. We've enjoyed getting to know more about you and your technical skillset. Now, we're gonna switch gears a little bit and do something else.

As part of this interview, we will evaluate your problem-solving skills using a short problem-solving task.
This task is very accurate and predictive of high-level problem-solving skills; typically people who do well on this task excel on the quantitative aspects of the job—which is critical for us.
For that reason, scores on this task are usually weighted more than most other components of the interview; What is it, \#1? I think—50% of our decision to hire will be based on your performance on this task is that right?

~set_name("")
Interviewer \#1 nods in agreement.

~set_name("Interviewer \#5")
We will have a scoreboard up for you showing the performance of candidates who scored in the top 5%. Last year we had some of the highest, if not the highest, most competitive performers.
Everyone interviewing this year—including you-- will have their performance rated or compared against these guys on the scoreboard…
Ideally we’d be looking to hire those with scores comparable to or higher than last year’s top scores (although higher might be quite hard to beat).
-> END

//then the score board is shown.
//Show score board—with 5 people and their percentile ranking (1-5%) also include a bogus score. The 5 people are 3 White men and 2 Asian men. Give them super White and Asian names e.g. Wyatt, Cheng, etc.

~set_name("")
X starts task.
After completing task- X is asked a few questions in a survey (up to 5- I will supply these) about interest in working for the company, stereotype endorsement, etc.

// Aaja section END
