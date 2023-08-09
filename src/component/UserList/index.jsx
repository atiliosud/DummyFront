import React from 'react';
import  './style.css';
import UserCard from '../UserCard';

export default ({data = []}) => {
    return (
        <div className='user-list-container'>
            {!data.length && (<p>No users to list</p>)}
            {data.map(item => <UserCard user={item}/>)}
        </div>
    )
}