using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System330 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component355> _p1;
EcsPool<Component172> _p2;
EcsPool<Component33> _p3;
EcsPool<Component270> _p4;
EcsPool<Component305> _pl0;
EcsPool<Component76> _pl1;
EcsPool<Component470> _pl2;
EcsPool<Component272> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component355>().Inc<Component172>().Inc<Component33>().Inc<Component270>().End();
   _p1 = _world.GetPool<Component355>();
   _p2 = _world.GetPool<Component172>();
   _p3 = _world.GetPool<Component33>();
   _p4 = _world.GetPool<Component270>();
   _pl0 = _world.GetPool<Component305>();
   _pl1 = _world.GetPool<Component76>();
   _pl2 = _world.GetPool<Component470>();
   _pl3 = _world.GetPool<Component272>();
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
