using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System302 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component438> _p1;
EcsPool<Component365> _p2;
EcsPool<Component168> _p3;
EcsPool<Component407> _p4;
EcsPool<Component199> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component438>().Inc<Component365>().Inc<Component168>().Inc<Component407>().End();
   _p1 = _world.GetPool<Component438>();
   _p2 = _world.GetPool<Component365>();
   _p3 = _world.GetPool<Component168>();
   _p4 = _world.GetPool<Component407>();
   _pl0 = _world.GetPool<Component199>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}
