class PromptGenerator{
    List<string> journalPrompts = new List<string>()
    {
        "Reflect on a recent challenge you faced and how you overcame it.",
        "Describe a moment that brought you joy today.",
        "Write about a goal you accomplished and how it made you feel.",
        "What are you grateful for in your life right now?",
        "Share a lesson you learned recently and how it impacted you.",
        "Write about a place you visited or want to visit and why.",
        "Describe a skill or hobby you want to learn and why it interests you.",
        "Reflect on a mistake you made and what you learned from it.",
        "Write about a book, movie, or song that resonated with you and why.",
        "What are your hopes and aspirations for the future?",
        "Describe a memorable interaction you had with someone recently.",
        "Write about a challenge you're currently facing and your plan to overcome it.",
        "Reflect on a moment when you felt proud of yourself.",
        "Share a random act of kindness you witnessed or performed recently.",
        "Write about a habit you want to cultivate and how you plan to do it.",
        "Describe an activity that helps you relax and unwind.",
        "Reflect on a decision you made recently and its consequences.",
        "What are you looking forward to in the upcoming week?",
        "Write about a fear you have and how you're working to overcome it.",
        "Describe a project or task you're currently working on and your progress.",
        "Share a childhood memory that still brings a smile to your face.",
        "Write about a role model or mentor who has inspired you.",
        "Reflect on the importance of self-care in your life.",
        "Describe a moment when you felt deeply connected to nature.",
        "Write about a personal value that guides your actions and decisions.",
    };

    public string GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(journalPrompts.Count);
        return journalPrompts[index];
    }
}