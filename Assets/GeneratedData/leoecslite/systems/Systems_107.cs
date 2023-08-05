using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System107 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component144> _p1;
EcsPool<Component142> _p2;
EcsPool<Component87> _p3;
EcsPool<Component122> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component144>().Inc<Component142>().Inc<Component87>().End();
   _p1 = _world.GetPool<Component144>();
   _p2 = _world.GetPool<Component142>();
   _p3 = _world.GetPool<Component87>();
   _pl0 = _world.GetPool<Component122>();
 }
 public void Run (EcsSystems systems) {
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
