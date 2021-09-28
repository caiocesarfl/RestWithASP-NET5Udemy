import React, {useState} from 'react';
import { useHistory } from 'react-router-dom';

import './styles.css';
import logoImage from '../../assets/logo.svg';
import padlock from '../../assets/padlock.png';
import api from '../../services/api'

export default function Login () {
    const [userName, setUserName] = useState('');
    const [password, setPassword] = useState('');

    const history = useHistory();

    async function login (e) {
        e.preventDefault();
    
        const data = {
            userName,
            password,
        };

        try {
           const response = await api.post('/api/Auth/v1/signin', data)
           localStorage.setItem('userName', userName);
           localStorage.setItem('acessToken', response.data.acessToken);
           localStorage.setItem('refrashToken', response.data.refrashToken);

           history.push('/books');

        } catch (error) {
            alert ('Login failed! Try again!')
        }
    }



    return (
        <div className="login-container">
            <section className="form">
                <img src={logoImage} alt="Caioba Logo"/>
                <form onSubmit = {login}>
                    <h1>Acess your Account</h1>

                    <input placeholder="Username"
                        value = {userName}
                        onChange = {e => setUserName(e.target.value)}
                    />
                    <input type="password"
                     placeholder="Password"
                     value = {password}
                     onChange = {e => setPassword(e.target.value)}
                    />
                    <button className="button" type="Submit">Login</button>
                </form>
            </section>

            <img src={padlock} alt="Login"/>
        </div>
    );
}