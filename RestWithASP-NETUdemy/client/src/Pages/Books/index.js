import React, {useState, useEffect} from 'react';
import { Link, useHistory } from 'react-router-dom';
import { FiPower, FiEdit, FiTrash2 } from 'react-icons/fi';
import './styles.css';

import api from '../../services/api'

import logoImage from '../../assets/logo.svg';

export default function Books () {
    const [books, setBooks] = useState([]);

    const userName = localStorage.getItem('userName');

    const acessToken = localStorage.getItem('acessToken');

    const history = useHistory();

    useEffect(() => {
        api.get('api/Book/v1/asc/5/1', {
            headers: {
                Authorization: `Bearer ${acessToken}`
            }   
        }).then((response) => {
            setBooks(response.data)
        })
    },[acessToken]);
 
    console.log (books);
    return (
        <div className="book-container">
            <header>
                <img src={logoImage} alt="Caioba logo"/>
                <span>Welcome, <strong>{userName.toUpperCase()}</strong></span>
                <Link className="button" to="book/new"> Add New Book </Link>
                <button type="button">
                    <FiPower size={18} color='#251FC5'></FiPower>
                </button>
            </header>
            <h1>Registred Books</h1>
            <ul>
                
                    {books.map(book => {
                        <li>
                               <strong>Title: </strong>
                               <p>{book.title}</p>
                               <strong>Author: </strong>
                               <p>{book.author}</p>
                               <strong>Price: </strong>
                               <p>{book.price}</p>
                               <strong>Release Date: </strong>
                               <p>{book.lauchDate}</p>
           
                               <button type="button"> 
                                   <FiEdit size={20} color="#251FC5"/>
                               </button>
           
                               <button type= "button">
                                   <FiTrash2 size={20} color="#251FC5"/>
                               </button>  
                        </li>
                    })}
            </ul>
        </div>
    );
}