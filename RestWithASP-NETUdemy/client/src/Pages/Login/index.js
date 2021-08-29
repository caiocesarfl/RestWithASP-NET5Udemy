import React from 'react';
import './styles.css';
import logoImage from '../../assets/logo.svg';
import padlock from '../../assets/padlock.png';

export default function Login () {
    return (
        <div className="login-container">
            <section className="form">
                <img src={logoImage} alt="Caioba Logo"/>
                <form>
                    <h1>Acess your Account</h1>
                    <input placeholder="Username"/>
                    <input type="password" placeholder="Password"/>
                    <button className="button" type="Submit">Login</button>
                </form>
            </section>

            <img src={padlock} alt="Login"/>
        </div>
    );
}