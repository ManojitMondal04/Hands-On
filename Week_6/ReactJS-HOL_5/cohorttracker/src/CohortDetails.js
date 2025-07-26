import React from 'react';
import styles from './CohortDetails.module.css';

function CohortDetails({ cohort }) {
  const headingColor = cohort.currentStatus.toLowerCase() === 'ongoing' ? 'green' : 'blue';

  return (
    <div className={styles.box}>
      <h3 style={{ color: headingColor }}>{cohort.cohortCode}</h3>
      <dl>
        <dt>Status:</dt>
        <dd>{cohort.currentStatus}</dd>

        <dt>Technology:</dt>
        <dd>{cohort.technology}</dd>

        <dt>Trainer:</dt>
        <dd>{cohort.trainerName}</dd>

        <dt>Coach:</dt>
        <dd>{cohort.coachName}</dd>

        <dt>Start Date:</dt>
        <dd>{cohort.startDate}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;
