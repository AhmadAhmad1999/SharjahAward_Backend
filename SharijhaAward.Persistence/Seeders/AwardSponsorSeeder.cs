﻿using SharijhaAward.Domain.Entities.AwardSponsorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class AwardSponsorSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public AwardSponsorSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.AwardSponsors.Any())
            {
               await _context.AwardSponsors.AddRangeAsync(
                    new AwardSponsor()
                    {
                        // Id =1,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicName = "صاحبِ السموّ الشيخ الدكتور سلطان بن محمد القاسمي، عضوِ المجلس الأعلى، حاكمِ الشارقةِ، إمارةِ الثقافةِ والتميّز",
                        EnglishName = "His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Supreme Council Member and Ruler of Sharjah",
                        ArabicDescription = "حفلت السيرة الذاتية لصاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الأعلى حاكم الشارقة بالعديد من الإنجازات التي تكشف عن اهتمام سموه المبكر بتحصيل العلوم بمختلف أنواعها، وحرص سموه على إفادة المجتمع من هذا العلم، سواء عن طريق إنشاء الكليات والجامعات، أو تأليف نحو 17 كتاباً ودراسة في مختلف أنواع الآداب والمعارف، رغم انشغال سموه بأمور الدولة، ومتابعة شؤون إمارة الشارقة الباسمة.\r\n\r\n \r\n\r\nإن منح صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الأعلى حاكم الشارقة دكتوراه فخرية من جامعة تيوبنجن الألمانية، تلك الجامعة التي تعد واحدة من أعرق الجامعات الألمانية يؤكد من جديد ما يتمتع به سموه حفظه الله من مكانة رفيعة بين الأوساط العلمية والأكاديمية، تلك المكانة التي تتوج مسيرة طويلة من الجهد المضني الذي بذله ويبذله سموه بتفان وإخلاص من أجل إرساء قواعد نهضة حقيقية للبلاد تنبعث من الإنسان الواعي المثقف الذي يتخذ من العلم والإيمان والثقافة طريقا وحياة ليجعل لبلاده مكاناً ومكانة رفيعة بين الأمم.\r\n\r\n \r\n\r\nتلك الرؤية العميقة لصاحب السمو حاكم الشارقة من أجل التطور والنهوض كانت دائماً هي الهاجس الذي كرس سموه من أجله وقته وحياته وبدأ من أجل تحقيقها مسيرة طويلة من الجهد والعمل الدؤؤوب.\r\n\r\n \r\n\r\nوقد كانت جهود سموه المشهودة الساعية باستمرار الى نشر العلم ودعم البحث العلمي والأخذ بأسبابه، وما يقدمه من مؤلفات وأبحاث ودراسات وآراء قيمة، وكذلك اهتمام كبير بنشر ثقافة الحوار بين الشعوب العربية والإسلامية وشعوب العالم الغربي، وسعي سموه المتواصل لدعم هذا التوجه عبر فعاليات ثقافية ومد خطوط تواصل دائمة بين الشارقة والعديد من البلدان الأوروبية، جعلت من سموه شخصية استثنائية بكل المقاييس وأحد أهم وأبرز شخصيات العالم العربي التي تحظي بتقدير عالمي في الأوساط الأكاديمية والعلمية ما حدا بجامعات العالم أن تسعى الى تكريم سموه وإهدائه أعلى درجاتها العلمية، وما حصول سموه بالأمس على الدكتوراه الفخرية من جامعة تيوبنجن الألمانية إلا تقديرا واعترافا جديدا بفضل سموه وشخصيته وجهوده وأعماله المقدرة.. ففضلا عن حصول سموه على درجة الدكتوراه في فلسفة التاريخ بامتياز من جامعة إكسيتر 1985م بالمملكة المتحدة ودرجة الدكتوراه في الفلسفة في الجغرافيا السياسية للخليج من جامعة دورهام 1999م بالمملكة المتحدة. فإن سموه يحمل تسع شهادات دكتوراه فخرية من أعرق الجامعات العربية والإسلامية والآسيوية والأوروبية حيث منح سموه دكتوراه فخرية في الآداب 1985م من جامعة أكستر بالمملكة المتحدة، في الحقوق 1986م من جامعة الخرطوم بالسودان، في القانون من جامعة ماك ماستر الكندية، في التاريخ من معهد الاستشراق التابع لأكاديمية العلوم الروسية، دكتوراه فخرية من جامعة فيصل أباد البنجاب في باكستان، من جامعة أدنبرة، من الجامعة الإسلامية العالمية بماليزيا، دكتوراه فخرية من جامعة ساوث بانك البريطانية وأخرى من أكاديمية العلوم القومية بجمهورية أرمينيا. هذا التكريم الذي صادف أهله بحق والذي حصل عليه سموه من جامعات العالم، والذي يشكل إجماعاً أكاديمياً على قدر سموه العلمي والإنساني وعلى قيمة وأهمية مايقدمه سموه لبلاده وشعبه من جهد وعمل، هو في حقيقة الأمر وسام على صدر كل ابن من أبناء الإمارات. بارك الله في جهود سموه  المخلصة البناءة التي تحث وتشهد على عظمة الإنسان عندما يكرس حياته وجهده وعمله لخدمة الوطن وأبنائه المخلصين.",
                        EnglishDescription = "The biography of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of Sharjah, is full of many achievements that reveal his early interest in acquiring all kinds of sciences. His Highness was keen to support the society with this knowledge, whether by establishing colleges and universities, or authoring more than 17 books and studies in various types of literature and knowledge, beside his responsibilities of country affairs, and following up on the affairs of the smiling Emirate of Sharjah.\r\n\r\n \r\n\r\nHis Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of Sharjah, has an honorary doctorate from the German University of Tuebingen, which is one of the ancient German universities. This confirms His Highness’s high status among the scientific and academic community. This prestige status culminates the long march of strenuous effort that His Highness made and is making with devotion and sincerity in order to empower the foundations for a real advantage for the country, emanating from the conscious and educated person who takes science, faith and culture as a path and life guide to give his country a high status place among nations.\r\n\r\n \r\n\r\nThat deep vision of His Highness the Ruler of Sharjah for development and advancement has always been the obsession for which His Highness devoted his time and life and began to achieve it through a long journey of effort and hard work.\r\n\r\n \r\n\r\nHis Highness's remarkable efforts were constantly attempt to spread knowledge, support scientific research and take into account its causes, and what his highness presents of valuable books, research, studies and opinions, as well as his great interest in spreading the culture of dialogue between the Arabic and Islamic people and the people of the Western world. His Highness' continuous endeavor to support this trend through cultural activities and extending permanent lines of communication between Sharjah and many European countries, made His Highness an exceptional personality by all standards and one of the most important and prominent personalities in the Arab world that enjoys global appreciation in the academic and scientific circles, which prompted the world's universities to seek to honor His Highness and bestow upon him the highest academic degrees. His Highness received an honorary doctorate from the University of Tuebingen in Germany, is an appreciation and recognition of His Highness, his personality, his efforts, and his appreciable work. In addition to his obtaining a PhD in Philosophy of History with distinction from the University of Exeter in 1985 in the United Kingdom, and a PhD in Philosophy in the Political Geography of the Gulf from Durham University in 1999 in the United Kingdom, His Highness holds nine honorary doctorates from the most prestigious Arab, Islamic, Asian and European universities. Furthermore, his Highness was awarded an honorary doctorate in literature in 1985 from the University of Exeter in the United Kingdom, in law in 1986 from the University of Khartoum in Sudan, in law from Canadian McMaster University, in history from the Oriental Institute of the Russian Academy of Sciences, an honorary doctorate from the University of Faisalabad Punjab in Pakistan, from University of Edinburgh, International Islamic University Malaysia, Honorary Doctorate from British South Bank University and another from the National Academy of Sciences of the Republic of Armenia. This honor which His Highness received from the universities of the world, constitutes an academic consensus on the scientific and human value of His Highness and on the value and importance of what His Highness offers to his country and his people of effort and work, is in fact a medal on the chest of every son of the Emirates. May God bless His Highness's sincere and constructive efforts that urge and testify to the greatness of man who devotes his life, effort and work to the country and people.",
                        Image = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                        ArabicUpbringingAndAiography = "هو صاحب السمو الشيخ الدكتور سلطان بن محمد بن صقر بن خالد بن سلطان بن صقر بن راشد القاسمي ولد يوم الأحد في الرابع عشر من جمادى الأولى سنة 1358 هـ، الموافق الثاني من يوليو عام 1939 م بمدينة الشارقة.\r\n\r\nوالدته الشيخة مريم بنت الشيخ غانم ابن الشيخ سالم بن عبدالله بن سعيد ابن سبت بن مطر بن سلطان بن فارس بن شهوان الشامسي.\r\n\r\nله من والدته من الأشقاء أربع الشيخ خالد والشيخ صقر والشيخ عبدالعزيز والشيخ عبدالله ومن  الشقيقات اثنتان الشيخة شيخة والشيخة ناعمة .\r\n\r\nولصاحب السمو حاكم الشارقة أخوة غير أشقاء هم الشيخ راشد والشيخ حميد والشيخ علي والشيخة موزة والشيخة علياء والشيخات غاية ونورة وعائشة وعزة.\r\n\r\nتزوج سموه من الشيخة موزة بنت سالم بن محمد ابن مانع الفلاسي (جدتها الشيخة موزة بنت الشيخ غانم ابن الشيخ سالم الشامسي خالة صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي)، وقد انجبت له ابنه المرحوم الشيخ محمد الذي توفي في الثالث من أبريل عام 1999 عن عمر يناهز 24 عاماً، وابنته الشيخة عزة .\r\n\r\nكما تزوج صاحب السمو حاكم الشارقة سمو الشيخة جواهر بنت الشيخ محمد بن سلطان بن صقر القاسمي ، وأنجبت له من الأبناء الشيخ خالد (توفي في 01 يوليو2019 عن عمر ناهز الأربعين عامًا) و الشيخة بدور والشيخة نور و الشيخة حور .. .\r\n\r\nتربى سموه على الوطنية، وترعرع على حب العلم والمعرفة، وكان شغوفا جدا بتاريخ وطنه، تفرغ في بداية عمره للدراسة وانتقل بين الشارقة والكويت ومصر ليتلقى تعليمه، وقد بدأ سموه تعليمه العام في شهر سبتمبر سنة 1948 في مدرسة الإصلاح القاسمية وكان عمره آنذاك تسع سنوات وشهرين، وكان قد درس سموه قبلها القرآن لدى الشيخ فارس ابن عبد الرحمن. وفي العام 1954 انضم صاحب السمو حاكم الشارقة للمدرسة الإنجليزية الخاصة ليدرس اللغة الإنجليزية. وانتقل سموه بين الشارقة والكويت لتلقي تعليمه الإعدادي والثانوي لينتهي به المطاف في نهاية عام 1965 في القاهرة حيث بدأ الدراسة الجامعية في كلية الزراعة بجامعة القاهرة.\r\n\r\nعمل سموه مدة عامين منذ فبراير عام 1961 وإلى سبتمبر 1963 كمدرس لمادتي اللغة الانجليزية والرياضيات بالمدرسة الصناعية بالشارقة.\r\n\r\nثم تسلم رئاسة البلدية في عام 1965 . وبعد عودته إلى الشارقة بعد اتمامه دراسته الجامعية عام 1971 تسلم صاحب السمو حاكم الشارقة إدارة مكتب سمو الحاكم بإمارة الشارقة.\r\n\r\nوبعد أيام من قيام اتحاد دولة الإمارات العربية المتحدة صباح يوم الثاني من ديسمبر عام 1971، وتحديداً في اليوم التاسع من ديسمبر تم تشكيل مجلس الوزراء ونصب صاحب السمو الشيخ الدكتور سلطان القاسمي يومها وزيراً للتربية والتعليم.\r\n\r\nوفي يوم الثلاثاء التاسع من ذي الحجة، يوم عرفة سنة 1391 هـ الموافق الخامس والعشرين من يناير 1972 تسلم صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي مقاليد حكم إمارة الشارقة بعد مقتل حاكم الشارقة آنذاك الشيخ خالد بن محمد القاسمي بعد انقلاب قاده الشيخ صقر بن سلطان القاسمي ، وليكون عضواً في المجلس الأعلى لدولة الامارات العربية المتحدة، وكان عمر سموه آنذاك 32 عاماً.\r\n\r\nويعد سموه الحاكم الثامن عشر لإمارة الشارقة من حكم القواسم الذي يعود للعام 1600 ميلادية.\r\n\r\nوقد قاد سموه التنمية الثقافية والاقتصادية والاجتماعية في إمارة الشارقة، وبذل سموه جهداً اضافياً ووفر مصادر لتشجيع التفاعل والحوار الثقافي محلياً واقليمياً ودولياً بين الشعوب كافة.",
                        EnglishUpbringingAndAiography = "He is His Highness Sheikh Dr. Sultan bin Muhammad bin Saqr bin Khalid bin Sultan bin Saqr bin Rashid Al Qasimi. He was born on Sunday, the fourteenth of Jumada Al-Awwal, 1358 AH, corresponding to the second of July, 1939 AD, in the city of Sharjah.\r\n\r\nHis mother is Sheikha Maryam, daughter of Sheikh Ghanem, son of Sheikh Salem bin Abdullah bin Saeed bin Sabt bin Matar bin Sultan bin Faris bin Shahwan Al Shamsi.\r\n\r\nHe has four brothers from his mother, Sheikh Khaled, Sheikh Saqr, Sheikh Abdulaziz, and Sheikh Abdullah, and two sisters, Sheikha Sheikha and Sheikha Naamah.\r\n\r\nHis Highness the Ruler of Sharjah has half-siblings, Sheikh Rashid, Sheikh Humaid, Sheikh Ali, Sheikha Moza, Sheikha Alia, and Sheikhs Ghaya, Noura, Aisha and Azza.\r\n\r\nHis Highness married Sheikha Moza bint Salem bin Mohammed bin Mani Al Falasi (her grandmother was Sheikha Moza bint Sheikh Ghanem bin Sheikh Salem Al Shamsi, aunt of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi), and she gave birth to his son, the late Sheikh Mohammed, who died on April 3, 1999. Omar is 24 years old, and his daughter, Sheikha Azza.\r\n\r\nHis Highness the Ruler of Sharjah also married Her Highness Sheikha Jawaher, daughter of Sheikh Mohammed bin Sultan bin Saqr Al Qasimi, and she bore him children Sheikh Khaled (died on July 1, 2019 at the age of forty), Sheikha Bodour, Sheikha Nour, and Sheikha Hoor...\r\n\r\nHis Highness was raised on patriotism, and he grew up with a love of science and knowledge, and he was very passionate about the history of his homeland. At the beginning of his life, he devoted himself to studying and moved between Sharjah, Kuwait, and Egypt to receive his education. His Highness began his general education in September 1948 at Al-Islah Al-Qasimia School, and he was nine years and two months old at the time. Before that, His Highness had studied the Qur’an with Sheikh Faris bin Abdul Rahman. In 1954, His Highness the Ruler of Sharjah joined the private English school to study the English language. His Highness moved between Sharjah and Kuwait to receive his preparatory and secondary education, ending up at the end of 1965 in Cairo, where he began university studies at the Faculty of Agriculture at Cairo University.\r\n\r\nHis Highness worked for two years from February 1961 to September 1963 as a teacher of English and mathematics at the Sharjah Industrial School.\r\n\r\nThen he assumed the presidency of the municipality in 1965. After his return to Sharjah after completing his university studies in 1971, His Highness the Ruler of Sharjah assumed the management of the Office of His Highness the Ruler in the Emirate of Sharjah.\r\n\r\nDays after the establishment of the United Arab Emirates on the morning of December 2, 1971, and specifically on the ninth of December, the Council of Ministers was formed and His Highness Sheikh Dr. Sultan Al Qasimi was appointed Minister of Education that day.\r\n\r\nOn Tuesday, the ninth of Dhu al-Hijjah, the day of Arafah in the year 1391 AH, corresponding to the twenty-fifth of January 1972, His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi took over the reins of rule of the Emirate of Sharjah after the killing of the ruler of Sharjah at the time, Sheikh Khalid bin Muhammad Al Qasimi, after a coup led by Sheikh Saqr bin Sultan Al Qasimi. To be a member of the Supreme Council of the United Arab Emirates, His Highness was 32 years old at the time.\r\n\r\nHis Highness is the eighteenth ruler of the Emirate of Sharjah during the Qawasim rule, which dates back to the year 1600 AD.\r\n\r\nHis Highness led the cultural, economic and social development in the Emirate of Sharjah, and His Highness made an additional effort and provided resources to encourage cultural interaction and dialogue locally, regionally and internationally among all peoples.",
                        Image2 = "https://award-shj.ae/media/bxpppdue/ddddd.png?crop=0,0.12824379935491048,0,0.41253923275760135&cropmode=percentage&width=1903&height=424&rnd=132551077852800000",
                        ArabicHonoraryPositions = "الزمالة الفخرية من المعهد الملكي للمهندسين المعماريين البريطانيين، تقديراً لجهود ومساهمات سموه الكبيرة في عالم التصميم والهندسة المعمارية ودوره في بناء مجتمعات أكثر استدامة، 02 نوفمبر 2018.\r\nالعضوية الفخرية بمجمع اللغة العربية وذلك تقديراً لدور سموه في خدمة اللغة والثقافة العربية، 24 ديسمبر 2015.\r\nالزمالة الفخرية من كليات الأطباء الملكية في كل من لندن وجلاسكو وأدنبرة وذلك تقديراً لدور سموه في دعم المسيرة التعليمية والطبية على مستوى العالم، 16 يونيو 2015.\r\nالرئيس الشرفي للاتحاد العربي للمرشدين السياحيين، 2013.\r\nالرئيس الفخري لاتحاد كتاب وأدباء الإمارات، 2012.\r\nالزمالة الشرفية من الكلية الملكية الإنجليزية للجراحيين، لندن، بريطانيا 12نوفمبر 2009.\r\nالرئيس الفخري لاتحاد الجامعات العربية، 2009.\r\nالرئيس الأعلى للهيئة العربية للمسرح،2008.\r\nالرئيس الفخري للجمعية العربية لعلوم الفضاء والفلك 2008.\r\nالرئيس الفخري للمؤسسة الدولية لتاريخ العلوم عند العرب والمسلمين 2008.\r\nالعضوية الفخرية باتحاد كتاب مصر 2008.\r\nالعضوية الشرفية، الجمعية الوطنية للجغرافيا، تقديراً لدعم سموه للجمعية الوطنية للجغرافيا بالولايات المتحدة الأمريكية، التي تأسست في عام 1888، للعناية بعلم الجغرافيا وتطوير البحث والاستكشاف، واشنطن، أمريكا يناير 2004.\r\nالرئيس الفخري للجمعية المصرية للدراسات التاريخية 2001.\r\nالرئيس الفخري للمؤسسة العربية للعلوم والتكنولوجيا، 2000.\r\nالرئيس الفخري للخدمات الجامعية العالمية 1998.\r\nالرئيس الفخري لمدينة الشارقة للخدمات الإنسانية 1998.\r\nالعضوية الفخرية في مركز الدراسات الشرق أوسطية والإسلامية، جامعة درم، المملكة المتحدة 22 اكتوبر 1992.\r\nالزمالة الفخرية، معهد الدراسات الأفريقية، جامعة الخرطوم، السودان، 1977.",
                        EnglishHonoraryPositions = "Honorary Fellowship from the Royal Institute of British Architects, in recognition of His Highness’s great efforts and contributions to the world of design and architecture and his role in building more sustainable societies, 02 November 2018.\r\nHonorary membership in the Arabic Language Academy in recognition of His Highness’s role in serving the Arabic language and culture, December 24, 2015.\r\nHonorary Fellowship from the Royal Colleges of Physicians in London, Glasgow and Edinburgh in recognition of His Highness’s role in supporting the educational and medical process worldwide, June 16, 2015.\r\nHonorary President of the Arab Federation of Tourist Guides, 2013.\r\nHonorary President of the Emirates Writers and Writers Union, 2012.\r\nHonorary Fellowship from the Royal College of Surgeons, London, Britain November 12, 2009.\r\nHonorary President of the Association of Arab Universities, 2009.\r\nSupreme President of the Arab Theater Authority, 2008.\r\nHonorary President of the Arab Society for Space and Astronomy 2008.\r\nHonorary President of the International Foundation for the History of Science among Arabs and Muslims 2008.\r\nHonorary membership in the Egyptian Writers Union 2008.\r\nHonorary Membership, National Geographic Society, in recognition of His Highness’s support for the National Geographic Society of the United States of America, which was founded in 1888, to care for the science of geography and develop research and exploration, Washington, America, January 2004.\r\nHonorary President of the Egyptian Society for Historical Studies 2001.\r\nHonorary President of the Arab Science and Technology Foundation, 2000.\r\nHonorary President of Global University Services 1998.\r\nHonorary President of Sharjah City for Humanitarian Services 1998.\r\nHonorary membership in the Center for Middle Eastern and Islamic Studies, Durham University, United Kingdom, October 22, 1992.\r\nHonorary Fellowship, Institute of African Studies, University of Khartoum, Sudan, 1977.",
                        Image3 = "https://award-shj.ae/media/bxpppdue/ddddd.png?crop=0,0.12824379935491048,0,0.41253923275760135&cropmode=percentage&width=1903&height=424&rnd=132551077852800000",
                        ArabicEducationalStages = "1948 التعليم الابتدائي - مدرسة الإصلاح القاسمية\r\nالتعليم الإعدادي والثانوي - الشارقة ودبي\r\n 1971 البكالوريوس في الزراعة - كلية الزراعة، جامعة القاهرة، القاهرة، مصر\r\nدكتوراه في التاريخ بامتياز - عن أطروحة تناولت مزاعم القرصنة ومحاولات شركة الهند الشرقية السيطرة على الخليج بين 1797-1820 ، جامعة إكسيتر، إكسيتر، المملكة المتحدة - 10 مايو 1985 م\r\nدكتوراه في الجغرافية السياسية للخليج - عن أطروحة بعنوان «صراع القوى والتجارة في الخليج خلال الفترة من سنة 1620 م وحتى سنة 1820 م» ، جامعة درهام، درهام، المملكة المتحدة ، 2 يوليو 1999 م",
                        EnglishEducationalStages = "1948 Primary Education - Al-Islah Al-Qasimiya School\r\nPreparatory and secondary education - Sharjah and Dubai\r\n  1971 Bachelor of Agriculture - Faculty of Agriculture, Cairo University, Cairo, Egypt\r\nDoctorate in History with distinction - on a thesis that dealt with allegations of piracy and the attempts of the East India Company to control the Gulf between 1797-1820, University of Exeter, Exeter, United Kingdom - May 10, 1985 AD\r\nDoctorate in the Political Geography of the Gulf - for a thesis entitled “Power Conflict and Trade in the Gulf during the Period from 1620 AD to 1820 AD,” Durham University, Durham, United Kingdom, July 2, 1999 AD.",
                        ArabicWritings = "صاحب السمو الشيخ الدكتور سلطان القاسمي، له العديد من المؤلفات منها\r\n\r\nمحاكم التفتيش\r\nسيرة مدينة (الجزء الأول)ـ\r\nسيرة مدينة (الجزء الثاني)ـ",
                        EnglishWritings = "His Highness Sheikh Dr. Sultan Al Qasimi has many publications, including:\r\n\r\ninquisition\r\nBiography of a city (Part One).\r\nBiography of a city (Part Two)."
                    });
                 await _context.SaveChangesAsync();
            }
        }
    }
}
