using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Previewer;

QuestPDF.Settings.License = LicenseType.Community;

int letterAddressSize = 18;
int letterSize = 15;
int headerTextSize = 40;
Document.Create(container =>
{
    container.Page(page =>
    {
        page.Size(PageSizes.A3);

        page.Background().Border(10).Background(Colors.Grey.Lighten3); ;

        page.Header().Padding(1, Unit.Centimetre).Background("#34568B")
           .Text(text =>
           {
               text.AlignCenter();
               text.Span("Motivational Letter")
                   .Underline()
                   .FontSize(headerTextSize)
                   .Bold().FontColor(Colors.White);
           });
        page.Content().Padding(1, Unit.Centimetre)
        .Column(x =>
        {
            x.Spacing(7);
            x.Item().Text(text =>
            {
                text.AlignLeft();
                text.Span("From:\nNAME" + $"\nEmail Address\nYour Address\nPhone Number").FontSize(letterAddressSize).FontFamily("Times New Roman");
            });
            x.Item().Text(text =>
            {
                text.AlignLeft();
                text.Span("\nTo:\nEmployer's name\nCompany Name\nCompany Address\nCompany Contacts\n").FontSize(letterAddressSize);
            });
            x.Item().Text(text =>
            {
                text.AlignLeft();
                text.Span(Environment.NewLine + $"Dear Employer Name").FontSize(letterSize);
            });
            x.Item().Text(text =>
            {
                text.AlignLeft();
                text.Span("\nI am writing to express my strong interest in the Junior .NET Developer position at [Company Name], as advertised on [Where You Found the Job Posting]. I am confident that my skills, experience, and passion make me an ideal candidate for this role.").FontSize(letterSize);
            });
            x.Item().Text(text =>
            {
                text.AlignLeft();
                text.Span("I have a solid foundation in C# and .NET framework, and I have successfully contributed to projects that required problem-solving, creativity, and a keen eye for detail. I am eager to further develop my expertise in .NET development and believe that the Junior .NET Developer role at [Company Name] is the perfect opportunity to do so.").FontSize(letterSize);
            });
            x.Item().Text(text =>
            {
                text.AlignLeft();
                text.Span("Through my research on [Company Name], I have been impressed by the company's commitment to innovation and its dedication to delivering high-quality software solutions. I am excited by the chance to work in an environment that values growth, learning, and collaboration, and I am confident that my technical skills and eagerness to learn will make a meaningful contribution to [Company Name]'s success.").FontSize(letterSize);
            });
            x.Item().Text(text =>
            {
                text.AlignLeft();
                text.Span("What truly motivates me about the Junior .NET Developer position is the opportunity to work on challenging projects and to be part of a team that is passionate about creating cutting-edge software solutions. I am a quick learner who is enthusiastic about staying updated on the latest industry trends and emerging technologies. I am confident that my problem-solving abilities and adaptability will help me thrive in a fast-paced and dynamic development environment.").FontSize(letterSize);
            });
            x.Item().Text(text =>
            {
                text.AlignLeft();
                text.Span("I have had the privilege of working on projects such as [Briefly Mention Relevant Project], where I successfully developed .NET applications that met and exceeded client expectations. I am excited about the prospect of applying my skills and knowledge to make an impact at [Company Name] and contribute to the development of innovative solutions that align with your mission.").FontSize(letterSize);
            });
            x.Item().Text(text =>
            {
                text.AlignLeft();
                text.Span("Thank you for considering my application. I am eager to discuss how my qualifications align with the needs of [Company Name] as a Junior .NET Developer. I look forward to the opportunity to demonstrate my passion for software development and my dedication to achieving results.").FontSize(letterSize);
            });
            x.Item().Text(text =>
            {
                text.AlignLeft();
                text.Span("\n\n\nSincerely,\n" + "NAME").FontSize(letterAddressSize);
            });
        });
    });
}).ShowInPreviewer();
        