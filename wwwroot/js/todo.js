//collect all dom elements
const todoInput = document.querySelector('.todoInput');
const addBtn = document.querySelector('#todoAdd');
const todoItems = document.querySelector('.todoItems');
const clrBtn = document.querySelector('.clearBtn');


//Create event listener for the add button
addBtn.addEventListener('click', (e) => {


    if (todoInput.value.length > 0 && todoInput.value.length >= 1 && !todoInput.value.match(/^\s*$/)) {

        const item = document.createElement('li');

      
        const itemValue = document.createTextNode(todoInput.value);

        item.appendChild(itemValue);

        todoItems.appendChild(item);
     
        todoItems.classList.add('todoItems');

        item.classList.add('items');

        const iconBox = document.createElement('span');

        iconBox.classList.add('iconBox');

        const completedBtn = document.createElement('button');
        const deleteBtn = document.createElement('button');

        completedBtn.innerHTML = "<i class='fas fa-check'> </i>";
        deleteBtn.innerHTML = "<i class= 'fas fa-trash-alt'></i>";

        completedBtn.classList.add('todoBtn');
        deleteBtn.classList.add('todoBtn');

        iconBox.appendChild(completedBtn);
        iconBox.appendChild(deleteBtn);

        item.appendChild(iconBox);

        todoInput.value = null;
        todoInput.focus();

        //Creating an event listener for both the delete and add button
        completedBtn.addEventListener('click', () => {
            alert('Task completed!');
            item.remove();
        })

        deleteBtn.addEventListener('click', () => {
            var ask = confirm('Are you sure?');

            if (ask === true) {
                alert('Task deleted!');
                item.remove();
            } else {
                return false
            }
        })

        //Creating an event listener for the "Clear all tasks" button
        clrBtn.addEventListener('click', () => {
            item.remove();
        })
    } else {
        alert('Input field cannot be empty!');
    }


})





