document.addEventListener('DOMContentLoaded', function() {
    const dropdownLinks = document.querySelectorAll('.dropdown-content a');
    const dropbtn = document.querySelector('.default-option');
    const searchBar = document.getElementById('search-bar');

    dropdownLinks.forEach(link => {
        link.addEventListener('click', function(event) {
            event.preventDefault();
            const option = this.textContent;
            dropbtn.textContent = option;
            searchBar.placeholder = `Search in ${option}`;
        });
    });
});

function performSearch() {
    const searchBar = document.getElementById('search-bar');
    const selectedOption = document.querySelector('.default-option').textContent;
    const query = searchBar.value;
    alert(`Searching for "${query}" in ${selectedOption}`);

}

