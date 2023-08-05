using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System215 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component108> _p1;
EcsPool<Component454> _p2;
EcsPool<Component315> _p3;
EcsPool<Component376> _pl0;
EcsPool<Component264> _pl1;
EcsPool<Component496> _pl2;
EcsPool<Component173> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component108>().Inc<Component454>().Inc<Component315>().End();
   _p1 = _world.GetPool<Component108>();
   _p2 = _world.GetPool<Component454>();
   _p3 = _world.GetPool<Component315>();
   _pl0 = _world.GetPool<Component376>();
   _pl1 = _world.GetPool<Component264>();
   _pl2 = _world.GetPool<Component496>();
   _pl3 = _world.GetPool<Component173>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl3.Has(entity))
   {
    q+=1;
    var component1 = _pl3.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
