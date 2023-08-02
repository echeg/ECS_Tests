using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System55 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component434> _p1;
EcsPool<Component477> _p2;
EcsPool<Component46> _p3;
EcsPool<Component360> _p4;
EcsPool<Component115> _pl0;
EcsPool<Component109> _pl1;
EcsPool<Component293> _pl2;
EcsPool<Component481> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component434>().Inc<Component477>().Inc<Component46>().Inc<Component360>().End();
   _p1 = _world.GetPool<Component434>();
   _p2 = _world.GetPool<Component477>();
   _p3 = _world.GetPool<Component46>();
   _p4 = _world.GetPool<Component360>();
   _pl0 = _world.GetPool<Component115>();
   _pl1 = _world.GetPool<Component109>();
   _pl2 = _world.GetPool<Component293>();
   _pl3 = _world.GetPool<Component481>();
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