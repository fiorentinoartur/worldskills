import React from 'react';
import "./Header.css"
import Main from '../Main/Main';
import Container from '../Container/Container';
import Logo from '../../Assets/Images/logoWorldSkills.png'
import Nav from '../Nav/Nav';

const Header = () => {
    return (
        <>
            <header className='header'>
                <div className='header-flex'>
                    <Container>
                        <Nav />
                    </Container>
                </div>
            </header>

        </>
    );
};

export default Header;