using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System115 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component280> _p1;
EcsPool<Component347> _p2;
EcsPool<Component438> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component280>().Inc<Component347>().Inc<Component438>().End();
   _p1 = _world.GetPool<Component280>();
   _p2 = _world.GetPool<Component347>();
   _p3 = _world.GetPool<Component438>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
