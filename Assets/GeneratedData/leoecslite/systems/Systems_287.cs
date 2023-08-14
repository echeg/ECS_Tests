using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System287 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component464> _p1;
EcsPool<Component144> _p2;
EcsPool<Component186> _p3;
EcsPool<Component261> _p4;
EcsPool<Component211> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component464>().Inc<Component144>().Inc<Component186>().Inc<Component261>().End();
   _p1 = _world.GetPool<Component464>();
   _p2 = _world.GetPool<Component144>();
   _p3 = _world.GetPool<Component186>();
   _p4 = _world.GetPool<Component261>();
   _pl0 = _world.GetPool<Component211>();
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
