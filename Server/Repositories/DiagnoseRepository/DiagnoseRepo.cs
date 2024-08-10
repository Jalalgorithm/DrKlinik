using DiseaseFinderApi;
using DrKlinik.Client.Pages;
using DrKlinik.Shared.DTO.Base;
using DrKlinik.Shared.DTO.Diagnose;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;



namespace DrKlinik.Server.Repositories.DiagnoseRepository
{
    public class DiagnoseRepo : IDiagnoseRepo
    {
        public async Task<Response> GeneralDiagnose(DiagnoseDTO detection)
        {
            if (detection == null)
            {
                return new Response
                {
                    Success = false,
                    Message = "Input valid details for diasgnosis"
                };
            }

            


            var sampleData = new   DiseaseFinder.ModelInput()
            {
                Itching = detection.Itching,
                Skin_rash = detection.SkinRash,
                Nodal_skin_eruptions = detection.NodalSkinEruptions,
                Continuous_sneezing = detection.ContinuousSneezing,
                Shivering = detection.Shivering,
                Chills = detection.Chills,
                Joint_pain = detection.JointPain,
                Stomach_pain = detection.StomachPain,
                Acidity = detection.Acidity,
                Ulcers_on_tongue = detection.Acidity,
                Muscle_wasting = detection.MuscleWasting,
                Vomiting = detection.Vomiting,
                Burning_micturition = detection.BurningMicturition,
                Spotting__urination = detection.SpottingUrination,
                Fatigue = detection.Fatigue,
                Weight_gain = detection.WeightGain,
                Anxiety = detection.Anxiety,
                Cold_hands_and_feets = detection.ColdHandsAndFeets,
                Mood_swings = detection.MoodSwings,
                Weight_loss = detection.WeightLoss,
                Restlessness = detection.Restlessness,
                Lethargy = detection.Lethargy,
                Patches_in_throat = detection.PatchesInThroat,
                Irregular_sugar_level = detection.IrregularSugarLevel,
                Cough = detection.Cough,
                High_fever = detection.HighFever,
                Sunken_eyes = detection.SunkenEyes,
                Breathlessness = detection.Breathlessness,
                Sweating = detection.Sweating,
                Dehydration = detection.Dehydration,
                Indigestion = detection.Indigestion,
                Headache = detection.Headache,
                Yellowish_skin = detection.YellowishSkin,
                Dark_urine = detection.DarkUrine,
                Nausea = detection.Nausea,
                Loss_of_appetite = detection.LossOfAppetite,
                Pain_behind_the_eyes = detection.PainBehindTheEyes,
                Back_pain = detection.BackPain,
                Constipation = detection.Constipation,
                Abdominal_pain = detection.AbdominalPain,
                Diarrhoea = detection.Diarrhoea,
                Mild_fever = detection.MildFever,
                Yellow_urine = detection.YellowUrine,
                Yellowing_of_eyes = detection.YellowingOfEyes,
                Acute_liver_failure = detection.AcuteLiverFailure,
                Fluid_overload = detection.FluidOverload,
                Swelling_of_stomach = detection.SwellingOfStomach,
                Swelled_lymph_nodes = detection.SwelledLymphNodes,
                Malaise = detection.Malaise,
                Blurred_and_distorted_vision = detection.BlurredAndDistortedVision,
                Phlegm = detection.Phlegm,
                Throat_irritation = detection.ThroatIrritation,
                Redness_of_eyes = detection.RednessOfEyes,
                Sinus_pressure = detection.SinusPressure,
                Runny_nose = detection.RunnyNose,
                Congestion = detection.Congestion,
                Chest_pain = detection.ChestPain,
                Weakness_in_limbs = detection.WeaknessInLimbs,
                Fast_heart_rate = detection.FastHeartRate,
                Pain_during_bowel_movements = detection.PainDuringBowelMovements,
                Pain_in_anal_region = detection.PainInAnalRegion,
                Bloody_stool = detection.BloodyStool,
                Irritation_in_anus = detection.IrritationInAnus,
                Neck_pain = detection.NeckPain,
                Dizziness = detection.Dizziness,
                Cramps = detection.Cramps,
                Bruising = detection.Bruising,
                Obesity = detection.Obesity,
                Swollen_legs = detection.SwollenLegs,
                Swollen_blood_vessels = detection.SwollenBloodVessels,
                Puffy_face_and_eyes = detection.PuffyFaceAndEyes,
                Enlarged_thyroid = detection.EnlargedThyroid,
                Brittle_nails = detection.BrittleNails,
                Swollen_extremeties = detection.SwollenExtremities,
                Excessive_hunger = detection.ExcessiveHunger,
                Extra_marital_contacts = detection.ExtraMaritalContacts,
                Drying_and_tingling_lips = detection.DryingAndTinglingLips,
                Slurred_speech = detection.SlurredSpeech,
                Knee_pain = detection.KneePain,
                Hip_joint_pain = detection.HipJointPain,
                Muscle_weakness = detection.MuscleWeakness,
                Stiff_neck = detection.StiffNeck,
                Swelling_joints = detection.SwellingJoints,
                Movement_stiffness = detection.MovementStiffness,
                Spinning_movements = detection.SpinningMovements,
                Loss_of_balance = detection.LossOfBalance,
                Unsteadiness = detection.Unsteadiness,
                Weakness_of_one_body_side = detection.WeaknessOfOneBodySide,
                Loss_of_smell = detection.LossOfSmell,
                Bladder_discomfort = detection.BladderDiscomfort,
                Foul_smell_of_urine = detection.FoulSmellOfUrine,
                Continuous_feel_of_urine = detection.ContinuousFeelOfUrine,
                Passage_of_gases = detection.PassageOfGases,
                Internal_itching = detection.InternalItching,
                Toxic_look__typhos_ = detection.ToxicLookTyphos,
                Depression = detection.Depression,
                Irritability = detection.Irritability,
                Muscle_pain = detection.MusclePain,
                Altered_sensorium = detection.AlteredSensorium,
                Red_spots_over_body = detection.RedSpotsOverBody,
                Belly_pain = detection.BellyPain,
                Abnormal_menstruation = detection.AbnormalMenstruation,
                Dischromic__patches = detection.DischromicPatches,
                Watering_from_eyes = detection.WateringFromEyes,
                Increased_appetite = detection.IncreasedAppetite,
                Polyuria = detection.Polyuria,
                Family_history = detection.FamilyHistory,
                Mucoid_sputum = detection.MucoidSputum,
                Rusty_sputum = detection.RustySputum,
                Lack_of_concentration = detection.LackOfConcentration,
                Visual_disturbances = detection.VisualDisturbances,
                Receiving_blood_transfusion = detection.ReceivingBloodTransfusion,
                Receiving_unsterile_injections = detection.ReceivingUnsterileInjections,
                Coma = detection.Coma,
                Stomach_bleeding = detection.StomachBleeding,
                Distention_of_abdomen = detection.DistentionOfAbdomen,
                History_of_alcohol_consumption = detection.HistoryOfAlcoholConsumption,
                Fluid_overload2 = detection.FluidOverload2,
                Blood_in_sputum = detection.BloodInSputum,
                Prominent_veins_on_calf = detection.ProminentVeinsOnCalf,
                Palpitations = detection.Palpitations,
                Painful_walking = detection.PainfulWalking,
                Pus_filled_pimples = detection.PusFilledPimples,
                Blackheads = detection.Blackheads,
                Scurring = detection.Scurring,
                Skin_peeling = detection.SkinPeeling,
                Silver_like_dusting = detection.SilverLikeDusting,
                Small_dents_in_nails = detection.SmallDentsInNails,
                Inflammatory_nails = detection.InflammatoryNails,
                Blister = detection.Blister,
                Red_sore_around_nose = detection.RedSoreAroundNose,
                Yellow_crust_ooze = detection.YellowCrustOoze
            };


            var result = DiseaseFinder.Predict(sampleData);

            if(result==null)
            {
                return new Response
                {
                    Success = false,
                    Message = "No result found!"
                };
            }

            var accuracy = result.Score[0];
            var prediction = result.PredictedLabel;

            var secondPrediction = result.PredictedLabel;
            var secondAccuracy = result.Score[1];


            return new Response
            {
                Success = true,
                Message = $"Disease {prediction} is detected on accuracy level {accuracy} while there is a probability for {secondPrediction} on {secondAccuracy} level"
            };



        }
    }
}
