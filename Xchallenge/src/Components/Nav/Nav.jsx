import React from 'react';
import "./Nav.css"
import { Link } from 'react-router-dom';
import Logo from '../../Assets/Images/logoWorldSkills.png'
const Nav = () => {
    return (
        <nav className='navbar'>
            <Link to="/" className='worldlogo'>
                <img
                    className="worldlogo__image"
                    src={Logo}
                    alt="Logo WorldSkills" />
            </Link>

            <div className="nav__items">
                <Link to="/" className='nav__item'>
                Home
                </Link>
                
                <Link to="/resultado" className='nav__item'>
                    Resultado
                </Link>
                <Link to="/login" className='nav__item'>
                   Login
                </Link>
            </div>
        </nav>
    );
};

export default Nav;