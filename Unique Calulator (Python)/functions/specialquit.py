import time

def special_quit():
    print("Huh? That... cannot be right...")
    time.sleep(1.25)
    print("Do you actually wanna quit?")
    time.sleep(3)

    quit_input_ans = input("yes/no: ").strip().lower()

    if not quit_input_ans:
        print("I can't compute nothing, come on give me something.")
        return special_quit()  # Recursively ask again

    if quit_input_ans.startswith('n'):
        print("Oh... OK.")
        time.sleep(1.5)
        print("Don't scare me like that! :(")
        time.sleep(2.0)
        return False

    elif quit_input_ans.startswith('y'):
        quit_input = input("Give me a name: ").strip()
        if not quit_input:  # Handle empty input
            print("I need a name! Try again.")
            return special_quit()

        print(f"{quit_input}?")
        time.sleep(1.25)
        print("...")
        time.sleep(3.5)
        print("Do you want to stay now?")
        time.sleep(3.0)
        print(f"Since I'm {quit_input} now... I don't wanna go...")
        time.sleep(3.5)
        print("Will you stay?")
        time.sleep(1.25)

        quit_input_ans = input("yes/no: ").strip().lower()
        if not quit_input_ans:
            print("I can't compute nothing, come on give me something.")
            return special_quit()

        if quit_input_ans.startswith('n'):
            print(":(")
            time.sleep(1.95)
            print("Bye...")
            print("Closing down...")
            time.sleep(3.05)
            quit()
        elif quit_input_ans.startswith('y'):
            print("Thank you for staying!")
            time.sleep(1.25)
            print("Returning to choices...")
            time.sleep(1.75)
            return False
