import React from 'react';
import "./HomePage.css";
import Main from '../../Components/Main/Main';
import Container from '../../Components/Container/Container';
import WordConnect from '../../Assets/Icons/worldConnect.png'
import { Button } from '../../Components/FormComponents/FormComponents';

const HomePage = () => {
    return (
   <>

    <Main>
        <Container>
            <div className="homeflex">
                <div className="firstPart">
                    <h1>Edições WorldSkills</h1>
                    <p>Tenha acesso a todas as últimas edições das Worldskills, se conecte com diversos países e conheça os mais prestigiados competidores e campeõs do mundo!!!</p>
                    <Button 
                    textButton="Cadastre-se"
                    />
                </div>
                <img src={WordConnect} className='worldConnect' alt="" />
            </div>
        </Container>
    </Main>
 
   </>
    );
};

export default HomePage;