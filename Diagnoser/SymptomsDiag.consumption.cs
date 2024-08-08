﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
public partial class SymptomsDiag
{
    /// <summary>
    /// model input class for SymptomsDiag.
    /// </summary>
    #region model input class
    public class ModelInput
    {
        [LoadColumn(0)]
        [ColumnName(@"itching")]
        public float Itching { get; set; }

        [LoadColumn(1)]
        [ColumnName(@"skin_rash")]
        public float Skin_rash { get; set; }

        [LoadColumn(2)]
        [ColumnName(@"nodal_skin_eruptions")]
        public float Nodal_skin_eruptions { get; set; }

        [LoadColumn(3)]
        [ColumnName(@"continuous_sneezing")]
        public float Continuous_sneezing { get; set; }

        [LoadColumn(4)]
        [ColumnName(@"shivering")]
        public float Shivering { get; set; }

        [LoadColumn(5)]
        [ColumnName(@"chills")]
        public float Chills { get; set; }

        [LoadColumn(6)]
        [ColumnName(@"joint_pain")]
        public float Joint_pain { get; set; }

        [LoadColumn(7)]
        [ColumnName(@"stomach_pain")]
        public float Stomach_pain { get; set; }

        [LoadColumn(8)]
        [ColumnName(@"acidity")]
        public float Acidity { get; set; }

        [LoadColumn(9)]
        [ColumnName(@"ulcers_on_tongue")]
        public float Ulcers_on_tongue { get; set; }

        [LoadColumn(10)]
        [ColumnName(@"muscle_wasting")]
        public float Muscle_wasting { get; set; }

        [LoadColumn(11)]
        [ColumnName(@"vomiting")]
        public float Vomiting { get; set; }

        [LoadColumn(12)]
        [ColumnName(@"burning_micturition")]
        public float Burning_micturition { get; set; }

        [LoadColumn(13)]
        [ColumnName(@"spotting_ urination")]
        public float Spotting__urination { get; set; }

        [LoadColumn(14)]
        [ColumnName(@"fatigue")]
        public float Fatigue { get; set; }

        [LoadColumn(15)]
        [ColumnName(@"weight_gain")]
        public float Weight_gain { get; set; }

        [LoadColumn(16)]
        [ColumnName(@"anxiety")]
        public float Anxiety { get; set; }

        [LoadColumn(17)]
        [ColumnName(@"cold_hands_and_feets")]
        public float Cold_hands_and_feets { get; set; }

        [LoadColumn(18)]
        [ColumnName(@"mood_swings")]
        public float Mood_swings { get; set; }

        [LoadColumn(19)]
        [ColumnName(@"weight_loss")]
        public float Weight_loss { get; set; }

        [LoadColumn(20)]
        [ColumnName(@"restlessness")]
        public float Restlessness { get; set; }

        [LoadColumn(21)]
        [ColumnName(@"lethargy")]
        public float Lethargy { get; set; }

        [LoadColumn(22)]
        [ColumnName(@"patches_in_throat")]
        public float Patches_in_throat { get; set; }

        [LoadColumn(23)]
        [ColumnName(@"irregular_sugar_level")]
        public float Irregular_sugar_level { get; set; }

        [LoadColumn(24)]
        [ColumnName(@"cough")]
        public float Cough { get; set; }

        [LoadColumn(25)]
        [ColumnName(@"high_fever")]
        public float High_fever { get; set; }

        [LoadColumn(26)]
        [ColumnName(@"sunken_eyes")]
        public float Sunken_eyes { get; set; }

        [LoadColumn(27)]
        [ColumnName(@"breathlessness")]
        public float Breathlessness { get; set; }

        [LoadColumn(28)]
        [ColumnName(@"sweating")]
        public float Sweating { get; set; }

        [LoadColumn(29)]
        [ColumnName(@"dehydration")]
        public float Dehydration { get; set; }

        [LoadColumn(30)]
        [ColumnName(@"indigestion")]
        public float Indigestion { get; set; }

        [LoadColumn(31)]
        [ColumnName(@"headache")]
        public float Headache { get; set; }

        [LoadColumn(32)]
        [ColumnName(@"yellowish_skin")]
        public float Yellowish_skin { get; set; }

        [LoadColumn(33)]
        [ColumnName(@"dark_urine")]
        public float Dark_urine { get; set; }

        [LoadColumn(34)]
        [ColumnName(@"nausea")]
        public float Nausea { get; set; }

        [LoadColumn(35)]
        [ColumnName(@"loss_of_appetite")]
        public float Loss_of_appetite { get; set; }

        [LoadColumn(36)]
        [ColumnName(@"pain_behind_the_eyes")]
        public float Pain_behind_the_eyes { get; set; }

        [LoadColumn(37)]
        [ColumnName(@"back_pain")]
        public float Back_pain { get; set; }

        [LoadColumn(38)]
        [ColumnName(@"constipation")]
        public float Constipation { get; set; }

        [LoadColumn(39)]
        [ColumnName(@"abdominal_pain")]
        public float Abdominal_pain { get; set; }

        [LoadColumn(40)]
        [ColumnName(@"diarrhoea")]
        public float Diarrhoea { get; set; }

        [LoadColumn(41)]
        [ColumnName(@"mild_fever")]
        public float Mild_fever { get; set; }

        [LoadColumn(42)]
        [ColumnName(@"yellow_urine")]
        public float Yellow_urine { get; set; }

        [LoadColumn(43)]
        [ColumnName(@"yellowing_of_eyes")]
        public float Yellowing_of_eyes { get; set; }

        [LoadColumn(44)]
        [ColumnName(@"acute_liver_failure")]
        public float Acute_liver_failure { get; set; }

        [LoadColumn(45)]
        [ColumnName(@"fluid_overload")]
        public float Fluid_overload { get; set; }

        [LoadColumn(46)]
        [ColumnName(@"swelling_of_stomach")]
        public float Swelling_of_stomach { get; set; }

        [LoadColumn(47)]
        [ColumnName(@"swelled_lymph_nodes")]
        public float Swelled_lymph_nodes { get; set; }

        [LoadColumn(48)]
        [ColumnName(@"malaise")]
        public float Malaise { get; set; }

        [LoadColumn(49)]
        [ColumnName(@"blurred_and_distorted_vision")]
        public float Blurred_and_distorted_vision { get; set; }

        [LoadColumn(50)]
        [ColumnName(@"phlegm")]
        public float Phlegm { get; set; }

        [LoadColumn(51)]
        [ColumnName(@"throat_irritation")]
        public float Throat_irritation { get; set; }

        [LoadColumn(52)]
        [ColumnName(@"redness_of_eyes")]
        public float Redness_of_eyes { get; set; }

        [LoadColumn(53)]
        [ColumnName(@"sinus_pressure")]
        public float Sinus_pressure { get; set; }

        [LoadColumn(54)]
        [ColumnName(@"runny_nose")]
        public float Runny_nose { get; set; }

        [LoadColumn(55)]
        [ColumnName(@"congestion")]
        public float Congestion { get; set; }

        [LoadColumn(56)]
        [ColumnName(@"chest_pain")]
        public float Chest_pain { get; set; }

        [LoadColumn(57)]
        [ColumnName(@"weakness_in_limbs")]
        public float Weakness_in_limbs { get; set; }

        [LoadColumn(58)]
        [ColumnName(@"fast_heart_rate")]
        public float Fast_heart_rate { get; set; }

        [LoadColumn(59)]
        [ColumnName(@"pain_during_bowel_movements")]
        public float Pain_during_bowel_movements { get; set; }

        [LoadColumn(60)]
        [ColumnName(@"pain_in_anal_region")]
        public float Pain_in_anal_region { get; set; }

        [LoadColumn(61)]
        [ColumnName(@"bloody_stool")]
        public float Bloody_stool { get; set; }

        [LoadColumn(62)]
        [ColumnName(@"irritation_in_anus")]
        public float Irritation_in_anus { get; set; }

        [LoadColumn(63)]
        [ColumnName(@"neck_pain")]
        public float Neck_pain { get; set; }

        [LoadColumn(64)]
        [ColumnName(@"dizziness")]
        public float Dizziness { get; set; }

        [LoadColumn(65)]
        [ColumnName(@"cramps")]
        public float Cramps { get; set; }

        [LoadColumn(66)]
        [ColumnName(@"bruising")]
        public float Bruising { get; set; }

        [LoadColumn(67)]
        [ColumnName(@"obesity")]
        public float Obesity { get; set; }

        [LoadColumn(68)]
        [ColumnName(@"swollen_legs")]
        public float Swollen_legs { get; set; }

        [LoadColumn(69)]
        [ColumnName(@"swollen_blood_vessels")]
        public float Swollen_blood_vessels { get; set; }

        [LoadColumn(70)]
        [ColumnName(@"puffy_face_and_eyes")]
        public float Puffy_face_and_eyes { get; set; }

        [LoadColumn(71)]
        [ColumnName(@"enlarged_thyroid")]
        public float Enlarged_thyroid { get; set; }

        [LoadColumn(72)]
        [ColumnName(@"brittle_nails")]
        public float Brittle_nails { get; set; }

        [LoadColumn(73)]
        [ColumnName(@"swollen_extremeties")]
        public float Swollen_extremeties { get; set; }

        [LoadColumn(74)]
        [ColumnName(@"excessive_hunger")]
        public float Excessive_hunger { get; set; }

        [LoadColumn(75)]
        [ColumnName(@"extra_marital_contacts")]
        public float Extra_marital_contacts { get; set; }

        [LoadColumn(76)]
        [ColumnName(@"drying_and_tingling_lips")]
        public float Drying_and_tingling_lips { get; set; }

        [LoadColumn(77)]
        [ColumnName(@"slurred_speech")]
        public float Slurred_speech { get; set; }

        [LoadColumn(78)]
        [ColumnName(@"knee_pain")]
        public float Knee_pain { get; set; }

        [LoadColumn(79)]
        [ColumnName(@"hip_joint_pain")]
        public float Hip_joint_pain { get; set; }

        [LoadColumn(80)]
        [ColumnName(@"muscle_weakness")]
        public float Muscle_weakness { get; set; }

        [LoadColumn(81)]
        [ColumnName(@"stiff_neck")]
        public float Stiff_neck { get; set; }

        [LoadColumn(82)]
        [ColumnName(@"swelling_joints")]
        public float Swelling_joints { get; set; }

        [LoadColumn(83)]
        [ColumnName(@"movement_stiffness")]
        public float Movement_stiffness { get; set; }

        [LoadColumn(84)]
        [ColumnName(@"spinning_movements")]
        public float Spinning_movements { get; set; }

        [LoadColumn(85)]
        [ColumnName(@"loss_of_balance")]
        public float Loss_of_balance { get; set; }

        [LoadColumn(86)]
        [ColumnName(@"unsteadiness")]
        public float Unsteadiness { get; set; }

        [LoadColumn(87)]
        [ColumnName(@"weakness_of_one_body_side")]
        public float Weakness_of_one_body_side { get; set; }

        [LoadColumn(88)]
        [ColumnName(@"loss_of_smell")]
        public float Loss_of_smell { get; set; }

        [LoadColumn(89)]
        [ColumnName(@"bladder_discomfort")]
        public float Bladder_discomfort { get; set; }

        [LoadColumn(90)]
        [ColumnName(@"foul_smell_of urine")]
        public float Foul_smell_of_urine { get; set; }

        [LoadColumn(91)]
        [ColumnName(@"continuous_feel_of_urine")]
        public float Continuous_feel_of_urine { get; set; }

        [LoadColumn(92)]
        [ColumnName(@"passage_of_gases")]
        public float Passage_of_gases { get; set; }

        [LoadColumn(93)]
        [ColumnName(@"internal_itching")]
        public float Internal_itching { get; set; }

        [LoadColumn(94)]
        [ColumnName(@"toxic_look_(typhos)")]
        public float Toxic_look__typhos_ { get; set; }

        [LoadColumn(95)]
        [ColumnName(@"depression")]
        public float Depression { get; set; }

        [LoadColumn(96)]
        [ColumnName(@"irritability")]
        public float Irritability { get; set; }

        [LoadColumn(97)]
        [ColumnName(@"muscle_pain")]
        public float Muscle_pain { get; set; }

        [LoadColumn(98)]
        [ColumnName(@"altered_sensorium")]
        public float Altered_sensorium { get; set; }

        [LoadColumn(99)]
        [ColumnName(@"red_spots_over_body")]
        public float Red_spots_over_body { get; set; }

        [LoadColumn(100)]
        [ColumnName(@"belly_pain")]
        public float Belly_pain { get; set; }

        [LoadColumn(101)]
        [ColumnName(@"abnormal_menstruation")]
        public float Abnormal_menstruation { get; set; }

        [LoadColumn(102)]
        [ColumnName(@"dischromic _patches")]
        public float Dischromic__patches { get; set; }

        [LoadColumn(103)]
        [ColumnName(@"watering_from_eyes")]
        public float Watering_from_eyes { get; set; }

        [LoadColumn(104)]
        [ColumnName(@"increased_appetite")]
        public float Increased_appetite { get; set; }

        [LoadColumn(105)]
        [ColumnName(@"polyuria")]
        public float Polyuria { get; set; }

        [LoadColumn(106)]
        [ColumnName(@"family_history")]
        public float Family_history { get; set; }

        [LoadColumn(107)]
        [ColumnName(@"mucoid_sputum")]
        public float Mucoid_sputum { get; set; }

        [LoadColumn(108)]
        [ColumnName(@"rusty_sputum")]
        public float Rusty_sputum { get; set; }

        [LoadColumn(109)]
        [ColumnName(@"lack_of_concentration")]
        public float Lack_of_concentration { get; set; }

        [LoadColumn(110)]
        [ColumnName(@"visual_disturbances")]
        public float Visual_disturbances { get; set; }

        [LoadColumn(111)]
        [ColumnName(@"receiving_blood_transfusion")]
        public float Receiving_blood_transfusion { get; set; }

        [LoadColumn(112)]
        [ColumnName(@"receiving_unsterile_injections")]
        public float Receiving_unsterile_injections { get; set; }

        [LoadColumn(113)]
        [ColumnName(@"coma")]
        public float Coma { get; set; }

        [LoadColumn(114)]
        [ColumnName(@"stomach_bleeding")]
        public float Stomach_bleeding { get; set; }

        [LoadColumn(115)]
        [ColumnName(@"distention_of_abdomen")]
        public float Distention_of_abdomen { get; set; }

        [LoadColumn(116)]
        [ColumnName(@"history_of_alcohol_consumption")]
        public float History_of_alcohol_consumption { get; set; }

        [LoadColumn(117)]
        [ColumnName(@"fluid_overload2")]
        public float Fluid_overload2 { get; set; }

        [LoadColumn(118)]
        [ColumnName(@"blood_in_sputum")]
        public float Blood_in_sputum { get; set; }

        [LoadColumn(119)]
        [ColumnName(@"prominent_veins_on_calf")]
        public float Prominent_veins_on_calf { get; set; }

        [LoadColumn(120)]
        [ColumnName(@"palpitations")]
        public float Palpitations { get; set; }

        [LoadColumn(121)]
        [ColumnName(@"painful_walking")]
        public float Painful_walking { get; set; }

        [LoadColumn(122)]
        [ColumnName(@"pus_filled_pimples")]
        public float Pus_filled_pimples { get; set; }

        [LoadColumn(123)]
        [ColumnName(@"blackheads")]
        public float Blackheads { get; set; }

        [LoadColumn(124)]
        [ColumnName(@"scurring")]
        public float Scurring { get; set; }

        [LoadColumn(125)]
        [ColumnName(@"skin_peeling")]
        public float Skin_peeling { get; set; }

        [LoadColumn(126)]
        [ColumnName(@"silver_like_dusting")]
        public float Silver_like_dusting { get; set; }

        [LoadColumn(127)]
        [ColumnName(@"small_dents_in_nails")]
        public float Small_dents_in_nails { get; set; }

        [LoadColumn(128)]
        [ColumnName(@"inflammatory_nails")]
        public float Inflammatory_nails { get; set; }

        [LoadColumn(129)]
        [ColumnName(@"blister")]
        public float Blister { get; set; }

        [LoadColumn(130)]
        [ColumnName(@"red_sore_around_nose")]
        public float Red_sore_around_nose { get; set; }

        [LoadColumn(131)]
        [ColumnName(@"yellow_crust_ooze")]
        public float Yellow_crust_ooze { get; set; }

        [LoadColumn(132)]
        [ColumnName(@"prognosis")]
        public string Prognosis { get; set; }

    }

    #endregion

    /// <summary>
    /// model output class for SymptomsDiag.
    /// </summary>
    #region model output class
    public class ModelOutput
    {
        [ColumnName(@"itching")]
        public float Itching { get; set; }

        [ColumnName(@"skin_rash")]
        public float Skin_rash { get; set; }

        [ColumnName(@"nodal_skin_eruptions")]
        public float Nodal_skin_eruptions { get; set; }

        [ColumnName(@"continuous_sneezing")]
        public float Continuous_sneezing { get; set; }

        [ColumnName(@"shivering")]
        public float Shivering { get; set; }

        [ColumnName(@"chills")]
        public float Chills { get; set; }

        [ColumnName(@"joint_pain")]
        public float Joint_pain { get; set; }

        [ColumnName(@"stomach_pain")]
        public float Stomach_pain { get; set; }

        [ColumnName(@"acidity")]
        public float Acidity { get; set; }

        [ColumnName(@"ulcers_on_tongue")]
        public float Ulcers_on_tongue { get; set; }

        [ColumnName(@"muscle_wasting")]
        public float Muscle_wasting { get; set; }

        [ColumnName(@"vomiting")]
        public float Vomiting { get; set; }

        [ColumnName(@"burning_micturition")]
        public float Burning_micturition { get; set; }

        [ColumnName(@"spotting_ urination")]
        public float Spotting__urination { get; set; }

        [ColumnName(@"fatigue")]
        public float Fatigue { get; set; }

        [ColumnName(@"weight_gain")]
        public float Weight_gain { get; set; }

        [ColumnName(@"anxiety")]
        public float Anxiety { get; set; }

        [ColumnName(@"cold_hands_and_feets")]
        public float Cold_hands_and_feets { get; set; }

        [ColumnName(@"mood_swings")]
        public float Mood_swings { get; set; }

        [ColumnName(@"weight_loss")]
        public float Weight_loss { get; set; }

        [ColumnName(@"restlessness")]
        public float Restlessness { get; set; }

        [ColumnName(@"lethargy")]
        public float Lethargy { get; set; }

        [ColumnName(@"patches_in_throat")]
        public float Patches_in_throat { get; set; }

        [ColumnName(@"irregular_sugar_level")]
        public float Irregular_sugar_level { get; set; }

        [ColumnName(@"cough")]
        public float Cough { get; set; }

        [ColumnName(@"high_fever")]
        public float High_fever { get; set; }

        [ColumnName(@"sunken_eyes")]
        public float Sunken_eyes { get; set; }

        [ColumnName(@"breathlessness")]
        public float Breathlessness { get; set; }

        [ColumnName(@"sweating")]
        public float Sweating { get; set; }

        [ColumnName(@"dehydration")]
        public float Dehydration { get; set; }

        [ColumnName(@"indigestion")]
        public float Indigestion { get; set; }

        [ColumnName(@"headache")]
        public float Headache { get; set; }

        [ColumnName(@"yellowish_skin")]
        public float Yellowish_skin { get; set; }

        [ColumnName(@"dark_urine")]
        public float Dark_urine { get; set; }

        [ColumnName(@"nausea")]
        public float Nausea { get; set; }

        [ColumnName(@"loss_of_appetite")]
        public float Loss_of_appetite { get; set; }

        [ColumnName(@"pain_behind_the_eyes")]
        public float Pain_behind_the_eyes { get; set; }

        [ColumnName(@"back_pain")]
        public float Back_pain { get; set; }

        [ColumnName(@"constipation")]
        public float Constipation { get; set; }

        [ColumnName(@"abdominal_pain")]
        public float Abdominal_pain { get; set; }

        [ColumnName(@"diarrhoea")]
        public float Diarrhoea { get; set; }

        [ColumnName(@"mild_fever")]
        public float Mild_fever { get; set; }

        [ColumnName(@"yellow_urine")]
        public float Yellow_urine { get; set; }

        [ColumnName(@"yellowing_of_eyes")]
        public float Yellowing_of_eyes { get; set; }

        [ColumnName(@"acute_liver_failure")]
        public float Acute_liver_failure { get; set; }

        [ColumnName(@"fluid_overload")]
        public float Fluid_overload { get; set; }

        [ColumnName(@"swelling_of_stomach")]
        public float Swelling_of_stomach { get; set; }

        [ColumnName(@"swelled_lymph_nodes")]
        public float Swelled_lymph_nodes { get; set; }

        [ColumnName(@"malaise")]
        public float Malaise { get; set; }

        [ColumnName(@"blurred_and_distorted_vision")]
        public float Blurred_and_distorted_vision { get; set; }

        [ColumnName(@"phlegm")]
        public float Phlegm { get; set; }

        [ColumnName(@"throat_irritation")]
        public float Throat_irritation { get; set; }

        [ColumnName(@"redness_of_eyes")]
        public float Redness_of_eyes { get; set; }

        [ColumnName(@"sinus_pressure")]
        public float Sinus_pressure { get; set; }

        [ColumnName(@"runny_nose")]
        public float Runny_nose { get; set; }

        [ColumnName(@"congestion")]
        public float Congestion { get; set; }

        [ColumnName(@"chest_pain")]
        public float Chest_pain { get; set; }

        [ColumnName(@"weakness_in_limbs")]
        public float Weakness_in_limbs { get; set; }

        [ColumnName(@"fast_heart_rate")]
        public float Fast_heart_rate { get; set; }

        [ColumnName(@"pain_during_bowel_movements")]
        public float Pain_during_bowel_movements { get; set; }

        [ColumnName(@"pain_in_anal_region")]
        public float Pain_in_anal_region { get; set; }

        [ColumnName(@"bloody_stool")]
        public float Bloody_stool { get; set; }

        [ColumnName(@"irritation_in_anus")]
        public float Irritation_in_anus { get; set; }

        [ColumnName(@"neck_pain")]
        public float Neck_pain { get; set; }

        [ColumnName(@"dizziness")]
        public float Dizziness { get; set; }

        [ColumnName(@"cramps")]
        public float Cramps { get; set; }

        [ColumnName(@"bruising")]
        public float Bruising { get; set; }

        [ColumnName(@"obesity")]
        public float Obesity { get; set; }

        [ColumnName(@"swollen_legs")]
        public float Swollen_legs { get; set; }

        [ColumnName(@"swollen_blood_vessels")]
        public float Swollen_blood_vessels { get; set; }

        [ColumnName(@"puffy_face_and_eyes")]
        public float Puffy_face_and_eyes { get; set; }

        [ColumnName(@"enlarged_thyroid")]
        public float Enlarged_thyroid { get; set; }

        [ColumnName(@"brittle_nails")]
        public float Brittle_nails { get; set; }

        [ColumnName(@"swollen_extremeties")]
        public float Swollen_extremeties { get; set; }

        [ColumnName(@"excessive_hunger")]
        public float Excessive_hunger { get; set; }

        [ColumnName(@"extra_marital_contacts")]
        public float Extra_marital_contacts { get; set; }

        [ColumnName(@"drying_and_tingling_lips")]
        public float Drying_and_tingling_lips { get; set; }

        [ColumnName(@"slurred_speech")]
        public float Slurred_speech { get; set; }

        [ColumnName(@"knee_pain")]
        public float Knee_pain { get; set; }

        [ColumnName(@"hip_joint_pain")]
        public float Hip_joint_pain { get; set; }

        [ColumnName(@"muscle_weakness")]
        public float Muscle_weakness { get; set; }

        [ColumnName(@"stiff_neck")]
        public float Stiff_neck { get; set; }

        [ColumnName(@"swelling_joints")]
        public float Swelling_joints { get; set; }

        [ColumnName(@"movement_stiffness")]
        public float Movement_stiffness { get; set; }

        [ColumnName(@"spinning_movements")]
        public float Spinning_movements { get; set; }

        [ColumnName(@"loss_of_balance")]
        public float Loss_of_balance { get; set; }

        [ColumnName(@"unsteadiness")]
        public float Unsteadiness { get; set; }

        [ColumnName(@"weakness_of_one_body_side")]
        public float Weakness_of_one_body_side { get; set; }

        [ColumnName(@"loss_of_smell")]
        public float Loss_of_smell { get; set; }

        [ColumnName(@"bladder_discomfort")]
        public float Bladder_discomfort { get; set; }

        [ColumnName(@"foul_smell_of urine")]
        public float Foul_smell_of_urine { get; set; }

        [ColumnName(@"continuous_feel_of_urine")]
        public float Continuous_feel_of_urine { get; set; }

        [ColumnName(@"passage_of_gases")]
        public float Passage_of_gases { get; set; }

        [ColumnName(@"internal_itching")]
        public float Internal_itching { get; set; }

        [ColumnName(@"toxic_look_(typhos)")]
        public float Toxic_look__typhos_ { get; set; }

        [ColumnName(@"depression")]
        public float Depression { get; set; }

        [ColumnName(@"irritability")]
        public float Irritability { get; set; }

        [ColumnName(@"muscle_pain")]
        public float Muscle_pain { get; set; }

        [ColumnName(@"altered_sensorium")]
        public float Altered_sensorium { get; set; }

        [ColumnName(@"red_spots_over_body")]
        public float Red_spots_over_body { get; set; }

        [ColumnName(@"belly_pain")]
        public float Belly_pain { get; set; }

        [ColumnName(@"abnormal_menstruation")]
        public float Abnormal_menstruation { get; set; }

        [ColumnName(@"dischromic _patches")]
        public float Dischromic__patches { get; set; }

        [ColumnName(@"watering_from_eyes")]
        public float Watering_from_eyes { get; set; }

        [ColumnName(@"increased_appetite")]
        public float Increased_appetite { get; set; }

        [ColumnName(@"polyuria")]
        public float Polyuria { get; set; }

        [ColumnName(@"family_history")]
        public float Family_history { get; set; }

        [ColumnName(@"mucoid_sputum")]
        public float Mucoid_sputum { get; set; }

        [ColumnName(@"rusty_sputum")]
        public float Rusty_sputum { get; set; }

        [ColumnName(@"lack_of_concentration")]
        public float Lack_of_concentration { get; set; }

        [ColumnName(@"visual_disturbances")]
        public float Visual_disturbances { get; set; }

        [ColumnName(@"receiving_blood_transfusion")]
        public float Receiving_blood_transfusion { get; set; }

        [ColumnName(@"receiving_unsterile_injections")]
        public float Receiving_unsterile_injections { get; set; }

        [ColumnName(@"coma")]
        public float Coma { get; set; }

        [ColumnName(@"stomach_bleeding")]
        public float Stomach_bleeding { get; set; }

        [ColumnName(@"distention_of_abdomen")]
        public float Distention_of_abdomen { get; set; }

        [ColumnName(@"history_of_alcohol_consumption")]
        public float History_of_alcohol_consumption { get; set; }

        [ColumnName(@"fluid_overload2")]
        public float Fluid_overload2 { get; set; }

        [ColumnName(@"blood_in_sputum")]
        public float Blood_in_sputum { get; set; }

        [ColumnName(@"prominent_veins_on_calf")]
        public float Prominent_veins_on_calf { get; set; }

        [ColumnName(@"palpitations")]
        public float Palpitations { get; set; }

        [ColumnName(@"painful_walking")]
        public float Painful_walking { get; set; }

        [ColumnName(@"pus_filled_pimples")]
        public float Pus_filled_pimples { get; set; }

        [ColumnName(@"blackheads")]
        public float Blackheads { get; set; }

        [ColumnName(@"scurring")]
        public float Scurring { get; set; }

        [ColumnName(@"skin_peeling")]
        public float Skin_peeling { get; set; }

        [ColumnName(@"silver_like_dusting")]
        public float Silver_like_dusting { get; set; }

        [ColumnName(@"small_dents_in_nails")]
        public float Small_dents_in_nails { get; set; }

        [ColumnName(@"inflammatory_nails")]
        public float Inflammatory_nails { get; set; }

        [ColumnName(@"blister")]
        public float Blister { get; set; }

        [ColumnName(@"red_sore_around_nose")]
        public float Red_sore_around_nose { get; set; }

        [ColumnName(@"yellow_crust_ooze")]
        public float Yellow_crust_ooze { get; set; }

        [ColumnName(@"prognosis")]
        public uint Prognosis { get; set; }

        [ColumnName(@"Features")]
        public float[] Features { get; set; }

        [ColumnName(@"PredictedLabel")]
        public string PredictedLabel { get; set; }

        [ColumnName(@"Score")]
        public float[] Score { get; set; }

    }

    #endregion

    private static string MLNetModelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SymptomsDiag.mlnet");

    public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


    private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
    {
        var mlContext = new MLContext();
        ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
        return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
    }

    /// <summary>
    /// Use this method to predict scores for all possible labels.
    /// </summary>
    /// <param name="input">model input.</param>
    /// <returns><seealso cref=" ModelOutput"/></returns>
    public static IOrderedEnumerable<KeyValuePair<string, float>> PredictAllLabels(ModelInput input)
    {
        var predEngine = PredictEngine.Value;
        var result = predEngine.Predict(input);
        return GetSortedScoresWithLabels(result);
    }

    /// <summary>
    /// Map the unlabeled result score array to the predicted label names.
    /// </summary>
    /// <param name="result">Prediction to get the labeled scores from.</param>
    /// <returns>Ordered list of label and score.</returns>
    /// <exception cref="Exception"></exception>
    public static IOrderedEnumerable<KeyValuePair<string, float>> GetSortedScoresWithLabels(ModelOutput result)
    {
        var unlabeledScores = result.Score;
        var labelNames = GetLabels(result);

        Dictionary<string, float> labledScores = new Dictionary<string, float>();
        for (int i = 0; i < labelNames.Count(); i++)
        {
            // Map the names to the predicted result score array
            var labelName = labelNames.ElementAt(i);
            labledScores.Add(labelName.ToString(), unlabeledScores[i]);
        }

        return labledScores.OrderByDescending(c => c.Value);
    }

    /// <summary>
    /// Get the ordered label names.
    /// </summary>
    /// <param name="result">Predicted result to get the labels from.</param>
    /// <returns>List of labels.</returns>
    /// <exception cref="Exception"></exception>
    private static IEnumerable<string> GetLabels(ModelOutput result)
    {
        var schema = PredictEngine.Value.OutputSchema;

        var labelColumn = schema.GetColumnOrNull("prognosis");
        if (labelColumn == null)
        {
            throw new Exception("prognosis column not found. Make sure the name searched for matches the name in the schema.");
        }

        // Key values contains an ordered array of the possible labels. This allows us to map the results to the correct label value.
        var keyNames = new VBuffer<ReadOnlyMemory<char>>();
        labelColumn.Value.GetKeyValues(ref keyNames);
        return keyNames.DenseValues().Select(x => x.ToString());
    }

    /// <summary>
    /// Use this method to predict on <see cref="ModelInput"/>.
    /// </summary>
    /// <param name="input">model input.</param>
    /// <returns><seealso cref=" ModelOutput"/></returns>
    public static ModelOutput Predict(ModelInput input)
    {
        var predEngine = PredictEngine.Value;
        return predEngine.Predict(input);
    }
}
