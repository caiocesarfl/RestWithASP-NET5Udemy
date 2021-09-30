import React, {useState} from 'react';
import {Link, useHistory} from 'react-router-dom'
import {FiAlertOctagon, FiArrowLeft} from 'react-icons/fi'
import api from '../../services/api'

import './styles.css';

import logoImage from '../../assets/logo.svg';

export default function NewBook () {
    

    const [title, setTitle] = useState('');
    const [author, setAuthor] = useState('');
    const [launchDate, setlaunchDate] = useState('');
    const [price, setPrice] = useState('');

    const history = useHistory();

    async function createNewBook(e) {
        e.preventDefault();
 
        const data = {
            title,
            author,
            launchDate,
            price
        }

        try { 
        const acessToken = localStorage.getItem('acessToken');
            const response = await api.post('api/Book/v1', data, {
                headers : {
                    'Content-Type' : 'application/json',
                    'Authorization' : `Bearer ${acessToken}`
                }
            });
        } catch (erro) {
            alert("Insert book failure" + erro);
        }
        history.push('/books');
    }   

    return (
        <div className="new-book-container">
            <div className="content">
                <section className="form">
                    <img src={logoImage} alt ="Erudio"/>
                    <h1>Add New Book</h1>
                    <p>Enter the book information and click on 'Add'</p>
                    <Link className="back-link" to="/books">
                        <FiArrowLeft size={16} color='#251fc5'/>
                        Home
                    </Link>
                </section>
                <form onSubmit={createNewBook}>
                    <input placeholder="Title"
                        value={title}
                        onChange={e => setTitle(e.target.value)}
                    />
                    <input placeholder="Author"
                        value={author}
                        onChange={e => setAuthor(e.target.value)}
                    />
                    <input type="date"
                        value={launchDate}
                        onChange={e => setlaunchDate(e.target.value)}
                    />
                    <input placeholder="Price"
                        value={price}
                        onChange={e => setPrice(e.target.value)}
                    />
                    <button className="button" type = "submit">Add</button>
                </form>
            </div>
        </div>
    );
}