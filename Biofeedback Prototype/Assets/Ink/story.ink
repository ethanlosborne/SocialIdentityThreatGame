//Link external functions here.
EXTERNAL set_name(name) //string. displays the speaker's name.
EXTERNAL set_background(bgIndex) //int. changes the bg image and uses a fade.
EXTERNAL set_portrait0(spriteIndex, posIndex) //int, int. waiting for more info about portraits first.
EXTERNAL set_portrait1(spriteIndex, posIndex) //int, int. waiting for more info about portraits first.
EXTERNAL play_music(whichTrack) //int. plays a looping track from soundManager's music array.
EXTERNAL play_sound(whichTrack) //int. plays a sound once track from soundManager's sound array.
EXTERNAL stop_music() //stops music.
//End external functions.

//You can call one like so:
//~ set_background(0)

-> invitation

// Marj section START
=== invitation ===

/* character limit test:
0123456789101112131415161718192021222324252627282930313233343536373839404142434445464748495051525354555657585960616263646566676869707172737475767778798081828384858687888990919293949596979899100101102103104105106107108109110111112113114115116117118119120121122123124125126127128129130131132133134135136137138139140141142143144145146147148149150151152153154155156157158159160161162163164165166167168169170171172173174175176177178179180181182183184185186187188189190191192193194195196197198199200201202203204205206207208209210211212213214215216217218219220221222223224225226227228229230231232233234235236237238239240241242243244245246247248249250251252253254255256257258259260261262263264265266267268269270271272273274275276277278279280281282283284285286287288289290291292293294295296297298299300301302303304305306307308309310311312313314315316317318319320321322323324325326327328329330331332333334335336337338339340341342343344345346347348349350351352353354355356357358359360361362363364365366367368369370371372373374375376377378379380381382383384385386387388389390391392393394395396397398399400401402403404405406407408409410411412413414415416417418419420421422423424425426427428429430431432433434435436437438439440441442443444445446447448449450451452453454455456457458459460461462463464465466467468469470471472473474475476477478479480481482483484485486487488489490491492493494495496497498499500501502503504505506507508509510511512513514515516517518519520521522523524525526527528529530531532533534535536537538539540541542543544545546547548549550551552553554555556557558559560561562563564565566567568569570571572573574575576577578579580581582583584585586587588589590591592593594595596597598599600601602603604605606607608609610611612613614615616617618619620621622623624625626627628629630631632633634635636637638639640641642643644645646647648649650651652653654655656657658659660661662663664665666667668669670671672673674675676677678679680681682683684685686687688689690691692693694695696697698699700701702703704705706707708709710711712713714715716717718719720721722723724725726727728729730731732733734735736737738739740741742743744745746747748749750751752753754755756757758759760761762763764765766767768769770771772773774775776777778779780781782783784785786787788789790791792793794795796797798799800801802803804805806807808809810811812813814815816817818819820821822823824825826827828829830831832833834835836837838839840841842843844845846847848849850851852853854855856857858859860861862863864865866867868869870871872873874875876877878879880881882883884885886887888889890891892893894895896897898899900901902903904905906907908909910911912913914915916917918919920921922923924925926927928929930931932933934935936937938939940941942943944945946947948949950951952953954955956957958959960961962963964965966967968969970971972973974975976977978979980981982983984985986987988989990991992993994995996997998999
result: 658 characters */

Part I: The Invitation

~ play_music(0)

Hello X! We are delighted to announce after reviewing hundreds of applications, you’ve been selected to interview for a summer internship with V Inc. In the next day or so, one of our HR representatives will be calling you to schedule an interview date. In the mean time, we would like to encourage you to learn a little more about our company by watching the informational video below.
This video provides an overview about our summer internship program, and the company as a whole. Thank you and we look forward to meeting you very soon!

*   [Watch the video] \[I started watching the video.\]
    ~ set_name("Emily Jacobs")
    ~ stop_music()
    ~ set_background(0)
    [intro music with voice over]: Hello, I’m Emily Jacobs, Director of the Summer Internship Program at V-Inc. First, I’d like to say congratulations on making it this far in the interview process. This makes you just one of 50 applicants to make it through our highly rigorous and selective process! I want to welcome you to a brief introduction to our company, V-Inc.

    V-Inc has been an innovative company since its inception in 1999, when it started out as a company providing I.T. training.  It eventually evolved to software development, focusing initially on customized software, and today V-Inc is a 800 Billion dollar global corporation with an unrivaled portfolio of end to end cutting edge solutions and services from software product development, to block-chain technologies and other smart contract related products. Ushering businesses into a new era of technology is what we do best at V-Inc. This is our mission.

    At V Inc we have the ability to make more of an impact on people and more of a change in one year than many people do in their lifetimes. The technology landscape is ever-changing. Six months can be the difference between obsolete and contemporary. Thus, to maintain our leadership position as innovators within the industry, we constantly seek and source the most brilliant, creative and talented young minds to join the team here at V-Inc. The summer internship program gives us the opportunity to train the best and the brightest, to scout exceptional talent that we know will advance our mission to remain at the forefront of innovative technologies. We typically graduate interns identified as exceptional into permanent positions within the company.
    * * (testimonials)[Watch testimonials from previous interns] \[I'm now watching testimonials from interns.\]
        * * * Jake Maxwell (White guy \#1, block chain data engineering intern)
            ~ set_name("Jake Maxwell")
              My name is Jake Maxwell, I’m a graduate intern here at V Inc. Just the process of coding is actually fun. It’s exciting to work at V inc because unlike a lot of other tech companies, V Inc is on the cutting edge of developing block chain technologies, which is revolutionizing the way smart contracts are executed. Block chain is the future and V-Inc is literally the rocket that’s taking us there.
              * * * * [Return to selection screen]
              -> testimonials
        * * * Paola Ortiz (Hispanic girl with accent, marketing intern)
            ~ set_name("Paola Ortiz")
            My name is Paola Ortiz. I go to the University of Denver and I study Marketing and communications. When I was young, I just looooved the jingles to commercials; I used to memorize TV commercials and act them out. It always fascinated me how one could see the beauty in every day things, and make others see that same beauty by playing with words.
            * * * * [Return to selection screen]
              -> testimonials
        * * * Connor McDermott (White guy \#2, financial analyst intern)
            ~ set_name("Connor McDermott")
            I’m Connor McDermott. I study Financial Mathematics at the Massachusetts Institute of Technology. I’m Interning here as a financial analyst and having the time of my life learning about equity options and pricing V Inc stock for the financial markets.

            Mathematics is beautiful. She is everywhere and in everything- take the Fibonacci sequence in nature, for example! I think if mathematics was a person I’d marry her! Getting up everyday to do what I love, with a super talented team at V-Inc is beyond the dream. Life couldn’t get any better for me.
            * * * * [Return to selection screen]
              -> testimonials

        * * * Zhang Wei (Asian girl, software engineering intern)
            ~ set_name("Zhang Wei")
            My name is Zhang Wei and I’m from New Haven, Connecticut, where I’m studying physics and computer science at Yale University. I’m an intern in the software engineering department at V Inc, where I’ve had the opportunity to work with so many leaders in the field. The mentorship has been nothing short of amazing; My coding skills have gone through the roof in such a short time and I’m currently working on writing my own code for a software program to improve technical interviewing in the tech industry. This is my greatest accomplishment yet and I’m excited to be part of the team.
            * * * * [Return to selection screen]
              -> testimonials

        * * * Logan Stiles (White guy \#3)
            ~ set_name("Logan Stiles")
            My name is Zhang Wei and I’m from New Haven, Connecticut, where I’m studying physics and computer science at Yale University. I’m an intern in the software engineering department at V Inc, where I’ve had the opportunity to work with so many leaders in the field. The mentorship has been nothing short of amazing; My coding skills have gone through the roof in such a short time and I’m currently working on writing my own code for a software program to improve technical interviewing in the tech industry. This is my greatest accomplishment yet and I’m excited to be part of the team.
            * * * * [Return to selection screen]
              -> testimonials

        * * * [Stop watching testimonials] \[I stopped watching testimonials.\]
            -> interviewStart

    * * (interviewStart) [Continue with the interview] \[I decided to continue with the interview.\]
        \[To be continued...\]

//ui stuff
~ set_background(1)

- -> manipulating_social_interactions_waiting_room
// Marj section END

// Mason section START
=== enter_building_reception ===
    ~ set_name("")
    On this day X has been invited to the company’s campus for an interview. Her appointment is set for 2:30pm. She walks into the building and checks in at the security desk; There are two security guards (men) at the front door—one Black, another Hispanic. X checks in at the security desk. She presents her interview card, and states that she is interviewing with Division D.
    Black Guard looks at her interview card and ID, checks her name on an ipad (or computer) and says: “10th Floor, Main reception area- right across the elevators.”
    X goes through security and is allowed into the foyer. It’s exquisite —well decorated, people in suits (men, mostly) walking about hurriedly, minding their own business. There seems to be a sense of urgency in this work environment.
    * * * [Head to the elevators] \[I walked to the elevators.\]
    X heads to the elevator. A cleaning lady (White woman) walks by with a cleaning cart and says ‘Hello’ to X as she continues on her way.
    * * * * [Press the 10th floor button] \[I pressed the 10th floor button.\]
    X takes the elevator to the 10th floor. Walks straight to the reception area and meets receptionist; a Black woman in her mid-thirties, with a short Afro.
    Receptionist: Good afternoon and welcome to Division D. How may I help you?
    X: [ this is free flow and X will have to state in her own words that she is there for the interview].
    Receptionist: The admin assistant interviews were done an hour ago. And that would have been down the hall, Room 1015. Sorry.
    X: [ states that she is here for the internship interview]
    Receptionist:  OHHH! I’m so sorry…we’re hosting 2 interviews today and one just wrapped up. What’s your name sweetie?
    X: X last name
    Receptionist: Types into a computer. Makes small talk.
    Wow! Engineering huh? You must be super smart [or a chop, or a genius]! Over 1000 applications each year for those positions and only about 10 make the final cut (she smiles at X).
    Receptionist prints out a paper with a number on it.  Gives the paper to X.
    OK. Your ticket number is D035. Go to the waiting area, room 1016-down the hall to your right-first door-- and wait for your number to be called over the intercom. The interview room will be RM 1018 directly opposite the waiting area. Shouldn’t be a long wait. Good luck.
    * * * * *  [Respond to the receptionist]
        -> manipulating_social_interactions_waiting_room
    * * * * * [Don't respond to the receptionist]
        -> manipulating_social_interactions_waiting_room
// Mason section END

// Marj section START
=== manipulating_social_interactions_waiting_room ===
X gets to Rm 1016. It is quite packed. She looks around. There are about 15 people waiting. Some are on their phones, others are chatting with each other…and some are reading books or just sitting staring into space. There’s only one other woman in the room besides herself. This woman is Asian. Of the 14 men, 8 are white, and 6 are Asian.

* [Find a seat]
She sits on the only available seat- next to an Asian man who begins to make small talk.

Asian guy: “You’re here for the internship interview?”

//X: “yes/ [or whatever variation of response X gives]”
** "Yes."

Asian guy: My name is Li Wang. You?

//X: X
*** "My name is X."

Li: Cool. What college?

//X: [whatever college she provides—I think we should provide her a college as part of her character, going in].
**** "I went to \[insert college\]."

Li: Sweet. Junior. M.I.T. Looks a little packed but they call people in quickly. I shouldn’t be too long now. Gets nerve-wracking just waiting in a room full of like…super smart people. See that guy over there with the red shirt? Also from M.I.T. His dad works for google. I’ll bet you he has an ‘in’ already. And the chic in the blue suit? [points to Asian woman]- total badass. Like … genius level smart! Seriously. Rumor has it that the big companies already scouting her for jobs after graduation.

X: [responds however she responds].
***** "\[insert response\]"

Li: I hear they hire mostly- well, last year at least—and the year before that- mostly M.I.T and Stanford grads. Like, most of the senior execs in this division graduated from either M.I.T, Harvard, Stanford or UCLA.

// Intercom buzzes and calls out a number—D-031.
****** \[The intercom buzzes and calls out a number-D-031.\]

Li: That’s me! Gotta go! Good luck.

- * [Head towards interview room] \[I headed towards the interview room.\]
    -> manipulating_social_interactions_interview_room

=== manipulating_social_interactions_interview_room ===
X walks across the hall to Rm 1018. On the walls are photos of executives… All White men. She opens the door and sees a panel of 4 interviewers sitting at a long table. 3 lean towards each other, whispering/ talking about something. One is writing something in a folder.

* [Walk into the room]
As she walks into the room, Interviewer \#5 comes in from a side door with a mug in hand. Looks at X and says “We’re out of coffee. What’s the status on the purchase order Lynette made last week? We’re supposed to restock when inventory hits 25%. Could you follow up on that please? I hate to micromanage but this is getting old!”

He walks to sit in the empty chair at the panel.

Interviewer \#3 points out that \#5 could be wrong about X: “ Er… wrong person, Stan. She’s not admin, she’s here for the interview. Right? Ms… X? D-035?”

//X: [nods, says yes, whatever—something affirmative].
** "Yes/something affirmative"

\#5 doesn’t apologize. Simply says ‘Oh! Ok- have a seat Ms. X and let’s get started”.

*** [Take a seat]
X sits opposite the panel.

\#1: Hello, X. Welcome to V, Inc. My name is A- this is B, C, D and E. We all are senior personnel in Division D- which is also one of the most crucial arms of the company. As a single division, we account for over 42% of the company’s annual revenue.

**** [...]
 As you know, our company is rated among top \#3 in the industry. Our success is mostly a result of our innovation in the field. We develop cutting edge products and the rest of the industry –and the market as well-- looks to us to determine the direction of the future, right?

 But here’s the thing—the secret to our success lies on being able to tap talent, fresh talent. So we are constantly looking to push the envelope ourselves, in terms what it means to be innovative and dominant in the field. So we look for and hire young people like yourself, who are not only talented, but also can bring to the table fresh, creative ideas.

 Typically, the internship is a bridge to becoming an employee within the organization. We invest heavily in our interns because we don’t just see them as gophers—but as valuable, future employees.

***** [...]
\#2 interjects… “yes and to what \#1 just said—because we are investing in you, we have very high standards and expectations around work quality and productivity. But I’ll say, should you be hired, you’ll have it made-even if you don’t end up with a position here.”

****** [...]
\#5: “And that’s what makes these internships so competitive. Having done an internship at V Inc is very attractive to a lot of companies out there—although to be honest, we tend to keep our interns- so the vetting process- of which this interview is a part—is very rigorous. We choose the best of the best. We receive about 1200 applications a year; interview about 50 candidates and only hire 12- a whopping 1%. So—you should consider it a success that you’ve made it this far.”

******* [...]
\#4: Alright, enough about us and the company. Tell us a little about yourself. I can see you’re a junior at [insert X’s college—definitely not the high end ones they come from].

As \#4 mentions the college, 2 interviewers look at each other and then look down.

X:  -----

- \#1: What are your skills and how do you think they can contribute to what our division goals?

//X: -------
******** \[insert response 1\]
            -> interviewLearn
******** \[insert response 2\]
            -> interviewLearn

- - (interviewLearn) \#2:  What are you hoping to learn from us this summer?

//X: -----------
******** \[insert response 1\]
                -> interviewCommStyle
******** \[insert response 2\]
                -> interviewCommStyle

- - - (interviewCommStyle) \#3:  What’s your communication style? I ask because most of the senior employees that you will be interfacing with in Division D are men – and we generally tend to be straight shooters who do not mince words & tell it like it is. I know some women might find that offensive so…. I guess I’m wondering how comfortable you would feel about that level of communication.

//X: -------
******** \[insert response 1\]
            -> manipulating_TASK_Gender_social_identity_threat
******** \[insert response 2\]
            -> manipulating_TASK_Gender_social_identity_threat

// Marj section END



// Aaja section
=== manipulating_TASK_Gender_social_identity_threat ===
\#5: Alright! Thank you, X! It was very nice to meet you. We've enjoyed getting to know more about you and your technical skills. Now, we're gonna switch gears a little bit and do something else.

* [...]

Part of this interview involves evaluating problem solving skills. So, we are gonna have you go to the next room to complete a problem solving task. This task is very predictive of high level problem solving skills and typically people who do well on this task excel on the quantitative aspects of the job—which is critical for us.

For that reason, we usually weight this aspect of the interview higher than most other components of the interview. What is it, \#1? I think—50% of our decision to hire will be based on your performance on this task, is that right? Yeah.

** [...]

We will have a scoreboard up for you showing the performance of candidates who scored in the top 5%. Last year we had some of the highest, if not the highest, most competitive performers. Everyone interviewing this year—including you-- will have their performance rated or compared against these guys on the scoreboard…

Ideally we’d be looking to hire those with scores comparable to or higher than—although higher is hard to beat—these top scorers.

-> END

//then the score board is shown.

//scoreboard names:
//Christopher Wyatt
//Emmanuel Letourneau
//Sheamus Bohannon
//Cheung Ting Lao
//Wang Yen-li

// Aaja section END
