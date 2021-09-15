import React from 'react';
import { Link } from 'react-router-dom';
import { FiPower, FiEdit, FiTrash2 } from 'react-icons/fi';
import './styles.css';

import logoImage from '../../assets/logo.svg';

export default function Books () {
    return (
        <div className="book-container">
            <header>
                <img src={logoImage} alt="Caioba logo"/>
                <span>Welcome, <strong>Ravi</strong></span>
                <Link className="button" to="book/new"> Add New Book </Link>
                <button type="button">
                    <FiPower size={18} color='#251FC5'></FiPower>
                </button>
            </header>
            <h1>Registred Books</h1>
            <ul>
                <li>
                    <strong>Title: </strong>
                    <p>Seja Foda</p>
                    <strong>Author: </strong>
                    <p>Caio Carneiro</p>
                    <strong>Price: </strong>
                    <p>R$ 25,00</p>
                    <strong>Release Date: </strong>
                    <p>25/10/2017</p>

                    <button type="button"> 
                        <FiEdit size={20} color="#251FC5"/>
                    </button>

                    <button type= "button">
                        <FiTrash2 size={20} color="#251FC5"/>
                    </button>
                </li>

                <li>
                    <strong>Title: </strong>
                    <p>Seja Foda</p>
                    <strong>Author: </strong>
                    <p>Caio Carneiro</p>
                    <strong>Price: </strong>
                    <p>R$ 25,00</p>
                    <strong>Release Date: </strong>
                    <p>25/10/2017</p>

                    <button type="button"> 
                        <FiEdit size={20} color="#251FC5"/>
                    </button>

                    <button type= "button">
                        <FiTrash2 size={20} color="#251FC5"/>
                    </button>
                </li>

                <li>
                    <strong>Title: </strong>
                    <p>Seja Foda</p>
                    <strong>Author: </strong>
                    <p>Caio Carneiro</p>
                    <strong>Price: </strong>
                    <p>R$ 25,00</p>
                    <strong>Release Date: </strong>
                    <p>25/10/2017</p>

                    <button type="button"> 
                        <FiEdit size={20} color="#251FC5"/>
                    </button>

                    <button type= "button">
                        <FiTrash2 size={20} color="#251FC5"/>
                    </button>
                </li>

                <li>
                    <strong>Title: </strong>
                    <p>Seja Foda</p>
                    <strong>Author: </strong>
                    <p>Caio Carneiro</p>
                    <strong>Price: </strong>
                    <p>R$ 25,00</p>
                    <strong>Release Date: </strong>
                    <p>25/10/2017</p>

                    <button type="button"> 
                        <FiEdit size={20} color="#251FC5"/>
                    </button>

                    <button type= "button">
                        <FiTrash2 size={20} color="#251FC5"/>
                    </button>
                </li>
            </ul>

        </div>
    );
}