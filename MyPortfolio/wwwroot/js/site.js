// Simple Typewriter Effect
document.addEventListener('DOMContentLoaded', function () {
    const typewriterElement = document.querySelector('.typewriter');
    if (typewriterElement) {
        // Updated words from your CV
        const words = ["Software Developer", "Creative Technologist", "Music Producer", "Innovator"];
        let wordIndex = 0;
        let charIndex = 0;
        let isDeleting = false;

        function type() {
            const currentWord = words[wordIndex];
            if (isDeleting) {
                // Deleting text
                typewriterElement.textContent = currentWord.substring(0, charIndex - 1);
                charIndex--;
            } else {
                // Typing text
                typewriterElement.textContent = currentWord.substring(0, charIndex + 1);
                charIndex++;
            }

            // If word is fully typed
            if (!isDeleting && charIndex === currentWord.length) {
                setTimeout(() => isDeleting = true, 2000); // Pause at end
            }
            // If word is fully deleted
            else if (isDeleting && charIndex === 0) {
                isDeleting = false;
                wordIndex = (wordIndex + 1) % words.length; // Move to next word
            }

            const typeSpeed = isDeleting ? 100 : 200;
            setTimeout(type, typeSpeed);
        }

        type();
    }
});


const currentLocation = location.href;
const navItems = document.querySelectorAll('.nav-link');
const navLength = navItems.length;
for (let i = 0; i < navLength; i++) {
    if (navItems[i].href === currentLocation) {
        navItems[i].className += " active";
    }
}