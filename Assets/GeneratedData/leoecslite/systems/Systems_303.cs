using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System303 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component294> _p1;
EcsPool<Component426> _p2;
EcsPool<Component20> _p3;
EcsPool<Component425> _p4;
EcsPool<Component306> _pl0;
EcsPool<Component269> _pl1;
EcsPool<Component496> _pl2;
EcsPool<Component346> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component294>().Inc<Component426>().Inc<Component20>().Inc<Component425>().End();
   _p1 = _world.GetPool<Component294>();
   _p2 = _world.GetPool<Component426>();
   _p3 = _world.GetPool<Component20>();
   _p4 = _world.GetPool<Component425>();
   _pl0 = _world.GetPool<Component306>();
   _pl1 = _world.GetPool<Component269>();
   _pl2 = _world.GetPool<Component496>();
   _pl3 = _world.GetPool<Component346>();
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
