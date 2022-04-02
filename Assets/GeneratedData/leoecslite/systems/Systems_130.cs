using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System130 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component374> _p1;
EcsPool<Component434> _p2;
EcsPool<Component274> _p3;
EcsPool<Component117> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component374>().Inc<Component434>().Inc<Component274>().Inc<Component117>().End();
   _p1 = _world.GetPool<Component374>();
   _p2 = _world.GetPool<Component434>();
   _p3 = _world.GetPool<Component274>();
   _p4 = _world.GetPool<Component117>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
