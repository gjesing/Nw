document.querySelector('#employeeTable').addEventListener('click', function (e) {
    e.srcElement.parentElement.classList.add('selected')
    document.querySelector('form button[type="submit"]').removeAttribute('disabled')
})