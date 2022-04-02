using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System192 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component91> _p1;
EcsPool<Component492> _p2;
EcsPool<Component109> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component91>().Inc<Component492>().Inc<Component109>().End();
   _p1 = _world.GetPool<Component91>();
   _p2 = _world.GetPool<Component492>();
   _p3 = _world.GetPool<Component109>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
